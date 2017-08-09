using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShtrihMReceiptPrint
{
    public partial class FormProduct : Form
    {
        public Product productForEdit;

        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            textDescription.Text = productForEdit.Description;
            textDepartment.Text = productForEdit.Department.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            productForEdit.Description = textDescription.Text;
            productForEdit.Department = DataModule.StrToIntDef(textDepartment.Text, 1);
        }
    }
}
