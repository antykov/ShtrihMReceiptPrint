using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShtrihMReceiptPrint
{
    public class SaleProduct
    {
        public Product Product { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    class DataModule
    {
        #region ФР

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool FreeLibrary(IntPtr hModule);

        internal delegate int PointerToMethodInvoker();

        static public DrvFRLib.DrvFR fr;
        static public bool frConnected;
        static public string frResultCodeDescription;

        public static bool CheckStrihFR()
        {
            frConnected = false;

            if (Type.GetTypeFromProgID("AddIn.DrvFR") == null)
            {
                string frDllPath = Path.Combine(Environment.CurrentDirectory, "DrvFR.dll");
                if (!File.Exists(frDllPath))
                {
                    MessageBox.Show("Отсутствует библиотека DrvFR.dll!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                try
                {
                    IntPtr hLib = LoadLibrary(frDllPath);
                    if (hLib == IntPtr.Zero)
                        throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());

                    IntPtr dllEntryPoint = GetProcAddress(hLib, "DllRegisterServer");
                    if (dllEntryPoint == IntPtr.Zero)
                        throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());

                    PointerToMethodInvoker dllRegisterDelegate =
                           (PointerToMethodInvoker)Marshal.GetDelegateForFunctionPointer(dllEntryPoint, typeof(PointerToMethodInvoker));
                    dllRegisterDelegate();

                    FreeLibrary(hLib);

                    if (Type.GetTypeFromProgID("AddIn.DrvFR") == null)
                        throw new Exception("Не удалось зарегистрировать библиотеку DrvFR.dll!");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка регистрации библиотеки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            fr = new DrvFRLib.DrvFR();

            return true;
        }

        public static void ConnectShrihFR()
        {
            frConnected = false;
            fr.Disconnect();

            fr.ComNumber = AppSettings.settings.DeviceComNumber;
            fr.BaudRate = AppSettings.settings.DeviceBaudRate;
            fr.Password = AppSettings.settings.DevicePassword;
            fr.Timeout = 200;
            fr.Connect();
            if (!CheckDeviceStatus())
                return;

            fr.CheckConnection();
            frConnected = CheckDeviceStatus();
        }

        private static bool CheckDeviceStatus()
        {
            if (fr.ResultCode == 0)
            {
                frResultCodeDescription = "";
                return true;
            }
            else
            {
                frResultCodeDescription = $"Ошибка устройства: {fr.ResultCodeDescription}";
                return false;
            }
        }

        public static string GetDeviceDescription()
        {
            fr.GetDeviceMetrics();
            if (!CheckDeviceStatus())
                return frResultCodeDescription;

            return $"Подключено устройство: {fr.UDescription}";
        }

        public static void PrintString(string stringForPrinting, HorizontalAlignment alignment, FontTypes fontType = FontTypes.Regular, bool isWrap = false)
        {
            DeviceFont font = AppSettings.settings.GetFontByType(fontType);

            List<string> lines = new List<string>();
            if (isWrap)
                lines = SplitByLength(stringForPrinting, font.SymbolsPerLine);
            else
                lines.Add(stringForPrinting);

            foreach (var line in lines)
            {
                fr.Password = AppSettings.settings.DevicePassword;
                fr.FontType = font.DeviceNumber;
                string formatted = FormatString(line, font.SymbolsPerLine, alignment);
                fr.StringForPrinting = formatted;
                fr.PrintStringWithFont();
            }
        }

        public static void PrintString(string stringForPrintingLeft, string stringForPrintingRight, FontTypes fontType = FontTypes.Regular)
        {
            DeviceFont font = AppSettings.settings.GetFontByType(fontType);

            StringBuilder stringForPrinting = new StringBuilder();
            stringForPrinting.Append(stringForPrintingLeft);
            stringForPrinting.Append(stringForPrintingRight);

            int spacesCount = font.SymbolsPerLine - (stringForPrintingLeft.Length + stringForPrintingRight.Length);
            if (spacesCount > 0)
                stringForPrinting.Insert(stringForPrintingLeft.Length, new String(' ', spacesCount));

            PrintString(stringForPrinting.ToString(), HorizontalAlignment.Left, fontType);
        }

        public static void PrintQRCode(DateTime checkDateTime, decimal amount, int fiscalDocument)
        {
            fr.Password = AppSettings.settings.DevicePassword;

            string qrCodeData = GetQRCodeData(checkDateTime, amount, fiscalDocument);
            int blockSize = 64;
            int blocks = (int)(qrCodeData.Length / blockSize) + (qrCodeData.Length % blockSize == 0 ? 0 : 1);
            for (int i = 0; i < blocks; i++)
            {
                StringBuilder dataPart = new StringBuilder();
                var bytes = Encoding.ASCII.GetBytes(qrCodeData.Substring(i * blockSize, Math.Min(blockSize, qrCodeData.Length - i * blockSize)));
                foreach (var b in bytes)
                {
                    dataPart.Append(b.ToString("X2"));
                }

                fr.BlockType = 0;
                fr.BlockNumber = i;
                fr.BlockDataHex = dataPart.ToString();
                fr.LoadBlockData();
                if (!CheckDeviceStatus())
                    throw new Exception(frResultCodeDescription);
            }

            fr.StringQuantity = 1;
            fr.FeedDocument();

            fr.BarcodeType = 3;
            fr.BarcodeDataLength = qrCodeData.Length;
            fr.BarcodeParameter3 = 5;
            fr.BarcodeParameter5 = 2;
            fr.BarcodeAlignment = 0;
            fr.Print2DBarcode();

            if (!CheckDeviceStatus())
                throw new Exception(frResultCodeDescription);

            fr.StringQuantity = 1;
            fr.FeedDocument();
        }

        public static void CutCheck()
        {
            fr.Password = AppSettings.settings.DevicePassword;

            fr.StringQuantity = 8;
            fr.FeedDocument();

            fr.CutType = false;
            fr.CutCheck();
        }

        #endregion

        public static string FormatString(string stringForPrinting, int symbolsPerLine, HorizontalAlignment alignment)
        {
            string result = stringForPrinting;

            switch (alignment)
            {
                case HorizontalAlignment.Left:
                    result = result.Substring(0, Math.Min(result.Length, symbolsPerLine));
                    break;
                case HorizontalAlignment.Right:
                    result = result.Substring(Math.Max(0, result.Length - symbolsPerLine)).PadLeft(symbolsPerLine, ' ');
                    break;
                case HorizontalAlignment.Center:
                    if (result.Length >= symbolsPerLine)
                        result = result.Substring(0, symbolsPerLine);
                    else
                        result = result.PadLeft(symbolsPerLine - (int)Math.Round((symbolsPerLine - result.Length) / 2.0));
                    break;
                default:
                    break;
            }

            return result;
        }

        public static int StrToIntDef(string s, int def)
        {
            int result;
            if (Int32.TryParse(s, out result))
                return result;
            else
                return def;
        }

        public static decimal StrToDecimalDef(string s, decimal def)
        {
            decimal result;
            if (Decimal.TryParse(s.Replace(",", "."), System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.InvariantCulture, out result))
                return result;
            else
                return def;
        }

        public static string GetQRCodeData(DateTime checkDateTime, decimal amount, int fiscalDocument)
        {
            StringBuilder result = new StringBuilder();

            result.Append("t=");
            result.Append(checkDateTime.ToString("yyyyMMddTHHmmss"));
            result.Append("&s=");
            result.Append(amount.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));
            result.Append("&fn=");
            result.Append(AppSettings.settings.FiscalNumber);
            result.Append("&i=");
            result.Append(fiscalDocument);
            result.Append("&fp=");
            result.Append(AppSettings.settings.FiscalSign);
            result.Append("&n=1");

            return result.ToString();
        }

        public static List<string> SplitByLength(string str, int maxLength)
        {
            List<string> result = new List<string>();

            for (int index = 0; index < str.Length; index += maxLength)
            {
                result.Add(str.Substring(index, Math.Min(maxLength, str.Length - index)));
            }

            return result;
        }

        public static string GetDepartmentQuantityPriceText(decimal quantity, decimal price, int department)
        {
            StringBuilder result = new StringBuilder();
            result.Append("  ");
            result.Append(department);
            result.Append("  ");
            result.Append(quantity.ToString("0.000", System.Globalization.CultureInfo.InvariantCulture));
            result.Append("x");
            result.Append("  ");
            result.Append(price.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));

            return result.ToString();
        }

        public static string GetAmountText(decimal quantity, decimal price, string taxSign = "")
        {
            StringBuilder result = new StringBuilder();
            result.Append("=");
            result.Append((price * quantity).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));
            result.Append(taxSign);

            return result.ToString();
        }

        public static string GetAmountText(decimal amount, string taxSign = "")
        {
            StringBuilder result = new StringBuilder();
            result.Append("=");
            result.Append(amount.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));
            result.Append(taxSign);

            return result.ToString();
        }

        public static string GetTaxText(decimal tax)
        {
            StringBuilder result = new StringBuilder();
            result.Append("=");
            result.Append(tax.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture));

            return result.ToString();
        }
    }
}
