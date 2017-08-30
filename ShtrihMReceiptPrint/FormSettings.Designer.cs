namespace ShtrihMReceiptPrint
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textCompany = new System.Windows.Forms.TextBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.labelCompanyINN = new System.Windows.Forms.Label();
            this.textCompanyINN = new System.Windows.Forms.TextBox();
            this.labelCashier = new System.Windows.Forms.Label();
            this.textCashier = new System.Windows.Forms.TextBox();
            this.labelFactoryNumber = new System.Windows.Forms.Label();
            this.textFactoryNumber = new System.Windows.Forms.TextBox();
            this.labelRegistrationNumber = new System.Windows.Forms.Label();
            this.textRegistrationNumber = new System.Windows.Forms.TextBox();
            this.labelFiscalNumber = new System.Windows.Forms.Label();
            this.textFiscalNumber = new System.Windows.Forms.TextBox();
            this.labelFiscalSign = new System.Windows.Forms.Label();
            this.textFiscalSign = new System.Windows.Forms.TextBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.labelProducts = new System.Windows.Forms.Label();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonShowPrinterSettings = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.labelComPort = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.labelCompanyAddress = new System.Windows.Forms.Label();
            this.textCompanyAddress = new System.Windows.Forms.TextBox();
            this.numericQRCodeDotSize = new System.Windows.Forms.NumericUpDown();
            this.labelQRCodeDotSize = new System.Windows.Forms.Label();
            this.labelQRCode = new System.Windows.Forms.Label();
            this.numericQRCodeCorrectionLevel = new System.Windows.Forms.NumericUpDown();
            this.labelQRCodeCorrectionLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericQRCodeDotSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQRCodeCorrectionLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // textCompany
            // 
            this.textCompany.Location = new System.Drawing.Point(90, 77);
            this.textCompany.Name = "textCompany";
            this.textCompany.Size = new System.Drawing.Size(232, 20);
            this.textCompany.TabIndex = 0;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(7, 80);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(77, 13);
            this.labelCompany.TabIndex = 1;
            this.labelCompany.Text = "Организация:";
            // 
            // labelCompanyINN
            // 
            this.labelCompanyINN.AutoSize = true;
            this.labelCompanyINN.Location = new System.Drawing.Point(328, 80);
            this.labelCompanyINN.Name = "labelCompanyINN";
            this.labelCompanyINN.Size = new System.Drawing.Size(34, 13);
            this.labelCompanyINN.TabIndex = 3;
            this.labelCompanyINN.Text = "ИНН:";
            // 
            // textCompanyINN
            // 
            this.textCompanyINN.Location = new System.Drawing.Point(378, 77);
            this.textCompanyINN.Name = "textCompanyINN";
            this.textCompanyINN.Size = new System.Drawing.Size(90, 20);
            this.textCompanyINN.TabIndex = 1;
            // 
            // labelCashier
            // 
            this.labelCashier.AutoSize = true;
            this.labelCashier.Location = new System.Drawing.Point(7, 131);
            this.labelCashier.Name = "labelCashier";
            this.labelCashier.Size = new System.Drawing.Size(47, 13);
            this.labelCashier.TabIndex = 5;
            this.labelCashier.Text = "Кассир:";
            // 
            // textCashier
            // 
            this.textCashier.Location = new System.Drawing.Point(90, 128);
            this.textCashier.Name = "textCashier";
            this.textCashier.Size = new System.Drawing.Size(378, 20);
            this.textCashier.TabIndex = 3;
            // 
            // labelFactoryNumber
            // 
            this.labelFactoryNumber.AutoSize = true;
            this.labelFactoryNumber.Location = new System.Drawing.Point(7, 156);
            this.labelFactoryNumber.Name = "labelFactoryNumber";
            this.labelFactoryNumber.Size = new System.Drawing.Size(49, 13);
            this.labelFactoryNumber.TabIndex = 7;
            this.labelFactoryNumber.Text = "ЗН ККТ:";
            // 
            // textFactoryNumber
            // 
            this.textFactoryNumber.Location = new System.Drawing.Point(90, 153);
            this.textFactoryNumber.Name = "textFactoryNumber";
            this.textFactoryNumber.Size = new System.Drawing.Size(378, 20);
            this.textFactoryNumber.TabIndex = 4;
            // 
            // labelRegistrationNumber
            // 
            this.labelRegistrationNumber.AutoSize = true;
            this.labelRegistrationNumber.Location = new System.Drawing.Point(7, 182);
            this.labelRegistrationNumber.Name = "labelRegistrationNumber";
            this.labelRegistrationNumber.Size = new System.Drawing.Size(49, 13);
            this.labelRegistrationNumber.TabIndex = 9;
            this.labelRegistrationNumber.Text = "РН ККТ:";
            // 
            // textRegistrationNumber
            // 
            this.textRegistrationNumber.Location = new System.Drawing.Point(90, 179);
            this.textRegistrationNumber.Name = "textRegistrationNumber";
            this.textRegistrationNumber.Size = new System.Drawing.Size(378, 20);
            this.textRegistrationNumber.TabIndex = 5;
            // 
            // labelFiscalNumber
            // 
            this.labelFiscalNumber.AutoSize = true;
            this.labelFiscalNumber.Location = new System.Drawing.Point(7, 208);
            this.labelFiscalNumber.Name = "labelFiscalNumber";
            this.labelFiscalNumber.Size = new System.Drawing.Size(29, 13);
            this.labelFiscalNumber.TabIndex = 11;
            this.labelFiscalNumber.Text = "ФН:";
            // 
            // textFiscalNumber
            // 
            this.textFiscalNumber.Location = new System.Drawing.Point(90, 205);
            this.textFiscalNumber.Name = "textFiscalNumber";
            this.textFiscalNumber.Size = new System.Drawing.Size(378, 20);
            this.textFiscalNumber.TabIndex = 6;
            // 
            // labelFiscalSign
            // 
            this.labelFiscalSign.AutoSize = true;
            this.labelFiscalSign.Location = new System.Drawing.Point(7, 234);
            this.labelFiscalSign.Name = "labelFiscalSign";
            this.labelFiscalSign.Size = new System.Drawing.Size(29, 13);
            this.labelFiscalSign.TabIndex = 13;
            this.labelFiscalSign.Text = "ФП:";
            // 
            // textFiscalSign
            // 
            this.textFiscalSign.Location = new System.Drawing.Point(90, 231);
            this.textFiscalSign.Name = "textFiscalSign";
            this.textFiscalSign.Size = new System.Drawing.Size(378, 20);
            this.textFiscalSign.TabIndex = 7;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(90, 257);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(313, 21);
            this.comboBoxProducts.TabIndex = 8;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(7, 260);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(49, 13);
            this.labelProducts.TabIndex = 15;
            this.labelProducts.Text = "Товары:";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(403, 256);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(23, 23);
            this.buttonAddProduct.TabIndex = 9;
            this.buttonAddProduct.Text = "+";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(424, 256);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(23, 23);
            this.buttonDeleteProduct.TabIndex = 10;
            this.buttonDeleteProduct.Text = "-";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(445, 256);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(23, 23);
            this.buttonEditProduct.TabIndex = 11;
            this.buttonEditProduct.Text = "...";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(262, 285);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 23);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(368, 285);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonShowPrinterSettings
            // 
            this.buttonShowPrinterSettings.Location = new System.Drawing.Point(90, 285);
            this.buttonShowPrinterSettings.Name = "buttonShowPrinterSettings";
            this.buttonShowPrinterSettings.Size = new System.Drawing.Size(166, 23);
            this.buttonShowPrinterSettings.TabIndex = 14;
            this.buttonShowPrinterSettings.Text = "Настройки принтера...";
            this.buttonShowPrinterSettings.UseVisualStyleBackColor = true;
            this.buttonShowPrinterSettings.Click += new System.EventHandler(this.buttonShowPrinterSettings_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(234, 12);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(88, 21);
            this.comboBoxBaudRate.TabIndex = 16;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(170, 16);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(58, 13);
            this.labelBaudRate.TabIndex = 25;
            this.labelBaudRate.Text = "Скорость:";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(90, 12);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(74, 21);
            this.comboBoxComPort.TabIndex = 15;
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(7, 16);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(60, 13);
            this.labelComPort.TabIndex = 23;
            this.labelComPort.Text = "COM-порт:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(328, 16);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(48, 13);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(378, 12);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(90, 20);
            this.textBoxPassword.TabIndex = 17;
            // 
            // labelSeparator
            // 
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator.Location = new System.Drawing.Point(87, 67);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(381, 2);
            this.labelSeparator.TabIndex = 29;
            // 
            // labelCompanyAddress
            // 
            this.labelCompanyAddress.AutoSize = true;
            this.labelCompanyAddress.Location = new System.Drawing.Point(7, 106);
            this.labelCompanyAddress.Name = "labelCompanyAddress";
            this.labelCompanyAddress.Size = new System.Drawing.Size(41, 13);
            this.labelCompanyAddress.TabIndex = 31;
            this.labelCompanyAddress.Text = "Адрес:";
            // 
            // textCompanyAddress
            // 
            this.textCompanyAddress.Location = new System.Drawing.Point(90, 103);
            this.textCompanyAddress.Name = "textCompanyAddress";
            this.textCompanyAddress.Size = new System.Drawing.Size(378, 20);
            this.textCompanyAddress.TabIndex = 2;
            // 
            // numericQRCodeDotSize
            // 
            this.numericQRCodeDotSize.Location = new System.Drawing.Point(275, 39);
            this.numericQRCodeDotSize.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericQRCodeDotSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericQRCodeDotSize.Name = "numericQRCodeDotSize";
            this.numericQRCodeDotSize.Size = new System.Drawing.Size(47, 20);
            this.numericQRCodeDotSize.TabIndex = 32;
            this.numericQRCodeDotSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelQRCodeDotSize
            // 
            this.labelQRCodeDotSize.AutoSize = true;
            this.labelQRCodeDotSize.Location = new System.Drawing.Point(189, 43);
            this.labelQRCodeDotSize.Name = "labelQRCodeDotSize";
            this.labelQRCodeDotSize.Size = new System.Drawing.Size(80, 13);
            this.labelQRCodeDotSize.TabIndex = 33;
            this.labelQRCodeDotSize.Text = "Размер точки:";
            // 
            // labelQRCode
            // 
            this.labelQRCode.AutoSize = true;
            this.labelQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQRCode.Location = new System.Drawing.Point(102, 43);
            this.labelQRCode.Name = "labelQRCode";
            this.labelQRCode.Size = new System.Drawing.Size(62, 13);
            this.labelQRCode.TabIndex = 34;
            this.labelQRCode.Text = "QR Code:";
            // 
            // numericQRCodeCorrectionLevel
            // 
            this.numericQRCodeCorrectionLevel.Location = new System.Drawing.Point(421, 39);
            this.numericQRCodeCorrectionLevel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericQRCodeCorrectionLevel.Name = "numericQRCodeCorrectionLevel";
            this.numericQRCodeCorrectionLevel.Size = new System.Drawing.Size(47, 20);
            this.numericQRCodeCorrectionLevel.TabIndex = 35;
            this.numericQRCodeCorrectionLevel.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelQRCodeCorrectionLevel
            // 
            this.labelQRCodeCorrectionLevel.Location = new System.Drawing.Point(328, 36);
            this.labelQRCodeCorrectionLevel.Name = "labelQRCodeCorrectionLevel";
            this.labelQRCodeCorrectionLevel.Size = new System.Drawing.Size(87, 27);
            this.labelQRCodeCorrectionLevel.TabIndex = 36;
            this.labelQRCodeCorrectionLevel.Text = "Уровень кор- рекции ошибок:";
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(477, 315);
            this.Controls.Add(this.numericQRCodeCorrectionLevel);
            this.Controls.Add(this.labelQRCodeCorrectionLevel);
            this.Controls.Add(this.labelQRCode);
            this.Controls.Add(this.numericQRCodeDotSize);
            this.Controls.Add(this.labelQRCodeDotSize);
            this.Controls.Add(this.labelCompanyAddress);
            this.Controls.Add(this.textCompanyAddress);
            this.Controls.Add(this.labelSeparator);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.labelComPort);
            this.Controls.Add(this.buttonShowPrinterSettings);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonEditProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.labelFiscalSign);
            this.Controls.Add(this.textFiscalSign);
            this.Controls.Add(this.labelFiscalNumber);
            this.Controls.Add(this.textFiscalNumber);
            this.Controls.Add(this.labelRegistrationNumber);
            this.Controls.Add(this.textRegistrationNumber);
            this.Controls.Add(this.labelFactoryNumber);
            this.Controls.Add(this.textFactoryNumber);
            this.Controls.Add(this.labelCashier);
            this.Controls.Add(this.textCashier);
            this.Controls.Add(this.labelCompanyINN);
            this.Controls.Add(this.textCompanyINN);
            this.Controls.Add(this.labelCompany);
            this.Controls.Add(this.textCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQRCodeDotSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQRCodeCorrectionLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCompany;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Label labelCompanyINN;
        private System.Windows.Forms.TextBox textCompanyINN;
        private System.Windows.Forms.Label labelCashier;
        private System.Windows.Forms.TextBox textCashier;
        private System.Windows.Forms.Label labelFactoryNumber;
        private System.Windows.Forms.TextBox textFactoryNumber;
        private System.Windows.Forms.Label labelRegistrationNumber;
        private System.Windows.Forms.TextBox textRegistrationNumber;
        private System.Windows.Forms.Label labelFiscalNumber;
        private System.Windows.Forms.TextBox textFiscalNumber;
        private System.Windows.Forms.Label labelFiscalSign;
        private System.Windows.Forms.TextBox textFiscalSign;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonShowPrinterSettings;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Label labelCompanyAddress;
        private System.Windows.Forms.TextBox textCompanyAddress;
        private System.Windows.Forms.NumericUpDown numericQRCodeDotSize;
        private System.Windows.Forms.Label labelQRCodeDotSize;
        private System.Windows.Forms.Label labelQRCode;
        private System.Windows.Forms.NumericUpDown numericQRCodeCorrectionLevel;
        private System.Windows.Forms.Label labelQRCodeCorrectionLevel;
    }
}