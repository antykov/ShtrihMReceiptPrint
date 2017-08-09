using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ShtrihMReceiptPrint
{
    public partial class FormMain : Form
    {
        public List<SaleProduct> salesProducts = new List<SaleProduct>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void UpdateControls() {
            salesProducts.Clear();
            foreach (var product in AppSettings.settings.Products)
            {
                salesProducts.Add(new SaleProduct() { Product = product, Description = product.Description, Quantity = 0, Price = 0M });
            }

            gridProducts.DataSource = null;
            gridProducts.AutoSize = true;
            gridProducts.AutoGenerateColumns = false;
            gridProducts.DataSource = salesProducts;

            DataModule.ConnectShrihFR();
            statusLabelFR.Text = $"{DataModule.GetDeviceDescription()}";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!DataModule.CheckStrihFR())
            {
                Close();
                return;
            }

            try
            {
                AppSettings.LoadSettings();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Загрузка настроек", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            PropertyInfo propertyBuffered = gridProducts.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            propertyBuffered.SetValue(gridProducts, true, null);

            UpdateControls();
        }

        private void menuItemSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            if (formSettings.ShowDialog() == DialogResult.OK)
                UpdateControls();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (!DataModule.frConnected)
                return;

            try
            {
                if (AppSettings.settings.DeviceFonts.Count == 0)
                    throw new Exception("Не определены настройки шрифтов принтера чеков!");

                var soldProducts = salesProducts.Where(w => w.Quantity > 0 && w.Price > 0).ToList();
                if (soldProducts.Count == 0)
                    throw new Exception("Не выбрано ни одного товара!");

                DateTime checkDateTime = DateTime.Now;
                decimal totalAmount = 0;
                decimal totalTax = 0;

                DataModule.PrintString(AppSettings.settings.CompanyName, HorizontalAlignment.Center);
                DataModule.PrintString("ДОБРО ПОЖАЛОВАТЬ !", HorizontalAlignment.Center);
                DataModule.PrintString("КАССОВЫЙ ЧЕК / ПРИХОД", HorizontalAlignment.Left);
                DataModule.PrintString($"НОМЕР СМЕНЫ {numericSessionNumber.Value.ToString("000000")}", $"ЧЕК {numericCheckNumber.Value.ToString("000000")}");
                DataModule.PrintString("CHO", "OCH");
                foreach (var soldProduct in soldProducts)
                {
                    DataModule.PrintString(soldProduct.Product.Description, HorizontalAlignment.Left);
                    DataModule.PrintString(
                        DataModule.GetDepartmentQuantityPriceText(soldProduct.Quantity, soldProduct.Price, soldProduct.Product.Department),
                        DataModule.GetAmountText(soldProduct.Quantity, soldProduct.Price, "B"));

                    totalAmount += Math.Round(soldProduct.Quantity * soldProduct.Price, 2, MidpointRounding.AwayFromZero);
                    totalTax += Math.Round(soldProduct.Quantity * soldProduct.Price * 18 / 118, 2, MidpointRounding.AwayFromZero);
                }
                DataModule.PrintString("ИТОГ", DataModule.GetAmountText(totalAmount), FontTypes.Bold);
                DataModule.PrintString(" B: СУММА НДС 18 %", DataModule.GetTaxText(totalTax));
                DataModule.PrintString("НАЛИЧНЫМИ", DataModule.GetAmountText(totalAmount));
                DataModule.PrintString("ЭЛЕКТРОННЫМИ", "=0.00");
                DataModule.PrintString($"{checkDateTime.ToString("dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture)} Кассир 1", HorizontalAlignment.Left);
                DataModule.PrintString($"ФИО {AppSettings.settings.Cashier}", HorizontalAlignment.Left);
                DataModule.PrintString("ЗН ККТ", AppSettings.settings.FactoryNumber);
                DataModule.PrintString("РН ККТ", AppSettings.settings.RegistrationNumber);
                DataModule.PrintString("САЙТ ФНС", "www.nalog.ru");
                DataModule.PrintString("АДРЕС РАСЧЕТОВ", HorizontalAlignment.Left);
                DataModule.PrintString(AppSettings.settings.CompanyAddress, HorizontalAlignment.Left, FontTypes.Regular, true);
                DataModule.PrintString("ИНН", AppSettings.settings.CompanyINN);
                DataModule.PrintString("ФН", AppSettings.settings.FiscalNumber);
                DataModule.PrintString($"ФД {numericFiscalDocumentNumber.Value.ToString("0000000000")}", $"ФП {AppSettings.settings.FiscalSign}");
                DataModule.PrintQRCode(checkDateTime, totalAmount, (int)numericFiscalDocumentNumber.Value);
                DataModule.PrintString("С П А С И Б О !", HorizontalAlignment.Center, FontTypes.SemiBold);

                DataModule.CutCheck();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка печати чека", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericControls_Enter(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length);
        }

        private void gridProducts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            string errorText = ((string)((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue).Replace(',', '.');
            decimal result;
            if (Decimal.TryParse(errorText, System.Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out result))
            {
                e.Cancel = false;
                ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value = result;
            }

        }
    }
}
