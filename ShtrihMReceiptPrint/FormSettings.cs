using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShtrihMReceiptPrint
{
    public partial class FormSettings : Form
    {

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
                comboBoxComPort.Items.Add($"COM{i}");
            if (AppSettings.settings.DeviceComNumber > 0 && AppSettings.settings.DeviceComNumber <= 20)
                comboBoxComPort.SelectedIndex = AppSettings.settings.DeviceComNumber - 1;
            else
                comboBoxComPort.SelectedIndex = 0;

            comboBoxBaudRate.SelectedIndex = Math.Max(0, comboBoxBaudRate.Items.IndexOf(AppSettings.settings.DeviceBaudRate.ToString()));

            textBoxPassword.Text = AppSettings.settings.DevicePassword.ToString();

            textCompany.Text = AppSettings.settings.CompanyName;
            textCompanyINN.Text = AppSettings.settings.CompanyINN;
            textCompanyAddress.Text = AppSettings.settings.CompanyAddress;
            textCashier.Text = AppSettings.settings.Cashier;
            textFactoryNumber.Text = AppSettings.settings.FactoryNumber;
            textRegistrationNumber.Text = AppSettings.settings.RegistrationNumber;
            textFiscalNumber.Text = AppSettings.settings.FiscalNumber;
            textFiscalSign.Text = AppSettings.settings.FiscalSign;

            foreach (var product in AppSettings.settings.Products)
            {
                comboBoxProducts.Items.Add(new Product(product));
            }

            if (comboBoxProducts.Items.Count > 0)
                comboBoxProducts.SelectedIndex = 0;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.productForEdit = new Product();
            if (formProduct.ShowDialog() == DialogResult.OK)
            {
                comboBoxProducts.Items.Add(new Product(formProduct.productForEdit));
                comboBoxProducts.SelectedIndex = comboBoxProducts.Items.Count - 1;
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            int index = comboBoxProducts.SelectedIndex;
            if (index == -1)
                return;

            if (MessageBox.Show("Вы действительно хотите удалить товар из списка?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comboBoxProducts.Items.RemoveAt(index);
                if (comboBoxProducts.Items.Count > 0)
                    comboBoxProducts.SelectedIndex = Math.Min(index, comboBoxProducts.Items.Count - 1);
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            int index = comboBoxProducts.SelectedIndex;
            if (index == -1)
                return;

            FormProduct formProduct = new FormProduct();
            formProduct.productForEdit = (Product)comboBoxProducts.SelectedItem;
            if (formProduct.ShowDialog() == DialogResult.OK)
            {
                comboBoxProducts.Items.RemoveAt(index);
                comboBoxProducts.Items.Insert(index, new Product(formProduct.productForEdit));
                comboBoxProducts.SelectedIndex = index;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AppSettings.settings.DeviceComNumber = comboBoxComPort.SelectedIndex + 1;
            AppSettings.settings.DeviceBaudRate = DataModule.StrToIntDef((string)comboBoxBaudRate.SelectedItem, 115200);
            AppSettings.settings.DevicePassword = DataModule.StrToIntDef(textBoxPassword.Text, 30);

            AppSettings.settings.CompanyName = textCompany.Text;
            AppSettings.settings.CompanyINN = textCompanyINN.Text;
            AppSettings.settings.CompanyAddress = textCompanyAddress.Text;
            AppSettings.settings.Cashier = textCashier.Text;
            AppSettings.settings.FactoryNumber = textFactoryNumber.Text;
            AppSettings.settings.RegistrationNumber = textRegistrationNumber.Text;
            AppSettings.settings.FiscalNumber = textFiscalNumber.Text;
            AppSettings.settings.FiscalSign = textFiscalSign.Text;

            AppSettings.settings.Products = new List<Product>();
            foreach (var product in comboBoxProducts.Items)
            {
                AppSettings.settings.Products.Add(new Product((Product)product));
            }

            AppSettings.SaveSettings();
        }

        private void buttonShowPrinterSettings_Click(object sender, EventArgs e)
        {
            DrvFRLib.DrvFR fr = new DrvFRLib.DrvFR();
            fr.ShowProperties();
        }
    }
}
