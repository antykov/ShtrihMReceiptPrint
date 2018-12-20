using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ShtrihMReceiptPrint
{
    public class Product
    {
        public string Description;
        public int Department;

        public override string ToString()
        {
            return $"{Description}";
        }

        public Product(Product product)
        {
            this.Description = product.Description;
            this.Department = product.Department;
        }

        public Product() { }
    }

    public enum FontTypes
    {
        Regular = 0,
        Bold = 1,
        SemiBold = 2
    }

    public class DeviceFont
    {
        public FontTypes FontType;
        public int DeviceNumber;
        public int SymbolsPerLine;
    }

    public class Settings
    {
        [XmlElement]
        public int DeviceComNumber;
        [XmlElement]
        public int DeviceBaudRate;
        [XmlElement]
        public int DevicePassword;

        [XmlElement]
        public string CompanyName;
        [XmlElement]
        public string CompanyINN;
        [XmlElement]
        public string CompanyAddress;
        [XmlElement]
        public string Cashier;
        [XmlElement]
        public string FactoryNumber;
        [XmlElement]
        public string RegistrationNumber;
        [XmlElement]
        public string FiscalNumber;
        [XmlElement]
        public string FiscalSign;
        [XmlElement]
        public string CompanyUser;
        [XmlElement]
        public string FRPlace;

        [XmlElement]
        public int QRCodeDotSize;
        [XmlElement]
        public int QRCodeCorrectionLevel;

        [XmlArray("Products"), XmlArrayItem("Product")]
        public List<Product> Products;

        [XmlArray("DeviceFonts"), XmlArrayItem("DeviceFont")]
        public List<DeviceFont> DeviceFonts;

        public Settings()
        {
            Products = new List<Product>();
            DeviceFonts = new List<DeviceFont>();

            QRCodeDotSize = 5;
            QRCodeCorrectionLevel = 2;
        }

        public DeviceFont GetFontByType(FontTypes fontType)
        {
            if (DeviceFonts.Count == 0)
                return new DeviceFont { FontType = FontTypes.Regular, DeviceNumber = 1, SymbolsPerLine = 16 };

            DeviceFont result = DeviceFonts.Where(w => w.FontType == fontType).First();
            if (result == null)
                result = DeviceFonts.Where(w => w.FontType == FontTypes.Regular).First();
            if (result == null)
                result = DeviceFonts[0];

            return result;
        }
    }

    public static class AppSettings
    {
        public static Settings settings = new Settings();

        public static void LoadSettings()
        {
            string settingsFilePath = Path.Combine(Environment.CurrentDirectory, "settings.xml");
            if (!File.Exists(settingsFilePath))
            {
                CreateTemplateSettingsFile(settingsFilePath);
                throw new Exception("Создан файл настроек. Заполните настройки!");
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));
            using (TextReader textReader = new StreamReader(settingsFilePath, Encoding.GetEncoding(1251)))
            {
                settings = (Settings)xmlSerializer.Deserialize(textReader);
            }
        }

        public static void SaveSettings()
        {
            string settingsFilePath = Path.Combine(Environment.CurrentDirectory, "settings.xml");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Encoding = Encoding.GetEncoding(1251);
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.IndentChars = ("\t");
            xmlWriterSettings.OmitXmlDeclaration = true;

            using (XmlWriter xmlWriter = XmlWriter.Create(settingsFilePath, xmlWriterSettings))
            {
                xmlSerializer.Serialize(xmlWriter, settings);
            }
        }

        public static void CheckSettings()
        {
        }

        private static void CreateTemplateSettingsFile(string settingsFilePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Settings));

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Encoding = Encoding.GetEncoding(1251);
            xmlWriterSettings.Indent = true;
            xmlWriterSettings.IndentChars = ("\t");
            xmlWriterSettings.OmitXmlDeclaration = true;

            Settings templateSettings = new Settings
            {
                DeviceComNumber = 1,
                DeviceBaudRate = 115200,
                DevicePassword = 30,
                CompanyName = "ООО \"Общество с ограниченной ответственностью\"",
                CompanyINN = "0000000000",
                CompanyAddress = "Россия",
                Cashier = "Иванов И.И.",
                FactoryNumber = "0000000000000000",
                RegistrationNumber = "0000000000000000",
                FiscalNumber = "0000000000000000",
                FiscalSign = "0000000000",
                CompanyUser = "ООО \"Общество с ограниченной ответственностью\"",
                FRPlace = "Место установки",
                QRCodeDotSize = 5,
                QRCodeCorrectionLevel = 2
            };
            templateSettings.Products.Add(new Product
            {
                Description = "Наименование товара",
                Department = 1
            });
            templateSettings.DeviceFonts.Add(new DeviceFont
            {
                FontType = FontTypes.Regular,
                DeviceNumber = 1,
                SymbolsPerLine = 32
            });
            templateSettings.DeviceFonts.Add(new DeviceFont
            {
                FontType = FontTypes.Bold,
                DeviceNumber = 2,
                SymbolsPerLine = 16
            });
            templateSettings.DeviceFonts.Add(new DeviceFont
            {
                FontType = FontTypes.SemiBold,
                DeviceNumber = 4,
                SymbolsPerLine = 16
            });

            using (XmlWriter xmlWriter = XmlWriter.Create(settingsFilePath, xmlWriterSettings))
            {
                xmlSerializer.Serialize(xmlWriter, templateSettings);
            }
        }
    }

}
