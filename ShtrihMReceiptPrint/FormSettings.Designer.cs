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
            this.labelCompanyUser = new System.Windows.Forms.Label();
            this.textCompanyUser = new System.Windows.Forms.TextBox();
            this.labelFRPlace = new System.Windows.Forms.Label();
            this.textFRPlace = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericQRCodeDotSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQRCodeCorrectionLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // textCompany
            // 
            this.textCompany.Location = new System.Drawing.Point(120, 95);
            this.textCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCompany.Name = "textCompany";
            this.textCompany.Size = new System.Drawing.Size(308, 22);
            this.textCompany.TabIndex = 0;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Location = new System.Drawing.Point(9, 98);
            this.labelCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(99, 17);
            this.labelCompany.TabIndex = 1;
            this.labelCompany.Text = "Организация:";
            // 
            // labelCompanyINN
            // 
            this.labelCompanyINN.AutoSize = true;
            this.labelCompanyINN.Location = new System.Drawing.Point(437, 98);
            this.labelCompanyINN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompanyINN.Name = "labelCompanyINN";
            this.labelCompanyINN.Size = new System.Drawing.Size(42, 17);
            this.labelCompanyINN.TabIndex = 3;
            this.labelCompanyINN.Text = "ИНН:";
            // 
            // textCompanyINN
            // 
            this.textCompanyINN.Location = new System.Drawing.Point(504, 95);
            this.textCompanyINN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCompanyINN.Name = "textCompanyINN";
            this.textCompanyINN.Size = new System.Drawing.Size(119, 22);
            this.textCompanyINN.TabIndex = 1;
            // 
            // labelCashier
            // 
            this.labelCashier.AutoSize = true;
            this.labelCashier.Location = new System.Drawing.Point(9, 189);
            this.labelCashier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCashier.Name = "labelCashier";
            this.labelCashier.Size = new System.Drawing.Size(59, 17);
            this.labelCashier.TabIndex = 5;
            this.labelCashier.Text = "Кассир:";
            // 
            // textCashier
            // 
            this.textCashier.Location = new System.Drawing.Point(120, 186);
            this.textCashier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCashier.Name = "textCashier";
            this.textCashier.Size = new System.Drawing.Size(503, 22);
            this.textCashier.TabIndex = 3;
            // 
            // labelFactoryNumber
            // 
            this.labelFactoryNumber.AutoSize = true;
            this.labelFactoryNumber.Location = new System.Drawing.Point(9, 220);
            this.labelFactoryNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFactoryNumber.Name = "labelFactoryNumber";
            this.labelFactoryNumber.Size = new System.Drawing.Size(62, 17);
            this.labelFactoryNumber.TabIndex = 7;
            this.labelFactoryNumber.Text = "ЗН ККТ:";
            // 
            // textFactoryNumber
            // 
            this.textFactoryNumber.Location = new System.Drawing.Point(120, 216);
            this.textFactoryNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFactoryNumber.Name = "textFactoryNumber";
            this.textFactoryNumber.Size = new System.Drawing.Size(503, 22);
            this.textFactoryNumber.TabIndex = 4;
            // 
            // labelRegistrationNumber
            // 
            this.labelRegistrationNumber.AutoSize = true;
            this.labelRegistrationNumber.Location = new System.Drawing.Point(9, 252);
            this.labelRegistrationNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegistrationNumber.Name = "labelRegistrationNumber";
            this.labelRegistrationNumber.Size = new System.Drawing.Size(62, 17);
            this.labelRegistrationNumber.TabIndex = 9;
            this.labelRegistrationNumber.Text = "РН ККТ:";
            // 
            // textRegistrationNumber
            // 
            this.textRegistrationNumber.Location = new System.Drawing.Point(120, 248);
            this.textRegistrationNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textRegistrationNumber.Name = "textRegistrationNumber";
            this.textRegistrationNumber.Size = new System.Drawing.Size(503, 22);
            this.textRegistrationNumber.TabIndex = 5;
            // 
            // labelFiscalNumber
            // 
            this.labelFiscalNumber.AutoSize = true;
            this.labelFiscalNumber.Location = new System.Drawing.Point(9, 284);
            this.labelFiscalNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiscalNumber.Name = "labelFiscalNumber";
            this.labelFiscalNumber.Size = new System.Drawing.Size(35, 17);
            this.labelFiscalNumber.TabIndex = 11;
            this.labelFiscalNumber.Text = "ФН:";
            // 
            // textFiscalNumber
            // 
            this.textFiscalNumber.Location = new System.Drawing.Point(120, 280);
            this.textFiscalNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFiscalNumber.Name = "textFiscalNumber";
            this.textFiscalNumber.Size = new System.Drawing.Size(503, 22);
            this.textFiscalNumber.TabIndex = 6;
            // 
            // labelFiscalSign
            // 
            this.labelFiscalSign.AutoSize = true;
            this.labelFiscalSign.Location = new System.Drawing.Point(9, 316);
            this.labelFiscalSign.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiscalSign.Name = "labelFiscalSign";
            this.labelFiscalSign.Size = new System.Drawing.Size(35, 17);
            this.labelFiscalSign.TabIndex = 13;
            this.labelFiscalSign.Text = "ФП:";
            // 
            // textFiscalSign
            // 
            this.textFiscalSign.Location = new System.Drawing.Point(120, 312);
            this.textFiscalSign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFiscalSign.Name = "textFiscalSign";
            this.textFiscalSign.Size = new System.Drawing.Size(503, 22);
            this.textFiscalSign.TabIndex = 7;
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(120, 344);
            this.comboBoxProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(416, 24);
            this.comboBoxProducts.TabIndex = 8;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(9, 348);
            this.labelProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(62, 17);
            this.labelProducts.TabIndex = 15;
            this.labelProducts.Text = "Товары:";
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(537, 343);
            this.buttonAddProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(31, 28);
            this.buttonAddProduct.TabIndex = 9;
            this.buttonAddProduct.Text = "+";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(565, 343);
            this.buttonDeleteProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(31, 28);
            this.buttonDeleteProduct.TabIndex = 10;
            this.buttonDeleteProduct.Text = "-";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.Location = new System.Drawing.Point(593, 343);
            this.buttonEditProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(31, 28);
            this.buttonEditProduct.TabIndex = 11;
            this.buttonEditProduct.Text = "...";
            this.buttonEditProduct.UseVisualStyleBackColor = true;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(349, 379);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(133, 28);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(491, 379);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(133, 28);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonShowPrinterSettings
            // 
            this.buttonShowPrinterSettings.Location = new System.Drawing.Point(120, 379);
            this.buttonShowPrinterSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowPrinterSettings.Name = "buttonShowPrinterSettings";
            this.buttonShowPrinterSettings.Size = new System.Drawing.Size(221, 28);
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
            this.comboBoxBaudRate.Location = new System.Drawing.Point(312, 15);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(116, 24);
            this.comboBoxBaudRate.TabIndex = 16;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(227, 20);
            this.labelBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(73, 17);
            this.labelBaudRate.TabIndex = 25;
            this.labelBaudRate.Text = "Скорость:";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(120, 15);
            this.comboBoxComPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(97, 24);
            this.comboBoxComPort.TabIndex = 15;
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(9, 20);
            this.labelComPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(79, 17);
            this.labelComPort.TabIndex = 23;
            this.labelComPort.Text = "COM-порт:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(437, 20);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(61, 17);
            this.labelPassword.TabIndex = 28;
            this.labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(504, 15);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(119, 22);
            this.textBoxPassword.TabIndex = 17;
            // 
            // labelSeparator
            // 
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator.Location = new System.Drawing.Point(116, 82);
            this.labelSeparator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(508, 2);
            this.labelSeparator.TabIndex = 29;
            // 
            // labelCompanyAddress
            // 
            this.labelCompanyAddress.AutoSize = true;
            this.labelCompanyAddress.Location = new System.Drawing.Point(9, 158);
            this.labelCompanyAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompanyAddress.Name = "labelCompanyAddress";
            this.labelCompanyAddress.Size = new System.Drawing.Size(52, 17);
            this.labelCompanyAddress.TabIndex = 31;
            this.labelCompanyAddress.Text = "Адрес:";
            // 
            // textCompanyAddress
            // 
            this.textCompanyAddress.Location = new System.Drawing.Point(120, 155);
            this.textCompanyAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCompanyAddress.Name = "textCompanyAddress";
            this.textCompanyAddress.Size = new System.Drawing.Size(503, 22);
            this.textCompanyAddress.TabIndex = 2;
            // 
            // numericQRCodeDotSize
            // 
            this.numericQRCodeDotSize.Location = new System.Drawing.Point(367, 48);
            this.numericQRCodeDotSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.numericQRCodeDotSize.Size = new System.Drawing.Size(63, 22);
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
            this.labelQRCodeDotSize.Location = new System.Drawing.Point(252, 53);
            this.labelQRCodeDotSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQRCodeDotSize.Name = "labelQRCodeDotSize";
            this.labelQRCodeDotSize.Size = new System.Drawing.Size(103, 17);
            this.labelQRCodeDotSize.TabIndex = 33;
            this.labelQRCodeDotSize.Text = "Размер точки:";
            // 
            // labelQRCode
            // 
            this.labelQRCode.AutoSize = true;
            this.labelQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQRCode.Location = new System.Drawing.Point(136, 53);
            this.labelQRCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQRCode.Name = "labelQRCode";
            this.labelQRCode.Size = new System.Drawing.Size(78, 17);
            this.labelQRCode.TabIndex = 34;
            this.labelQRCode.Text = "QR Code:";
            // 
            // numericQRCodeCorrectionLevel
            // 
            this.numericQRCodeCorrectionLevel.Location = new System.Drawing.Point(561, 48);
            this.numericQRCodeCorrectionLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericQRCodeCorrectionLevel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericQRCodeCorrectionLevel.Name = "numericQRCodeCorrectionLevel";
            this.numericQRCodeCorrectionLevel.Size = new System.Drawing.Size(63, 22);
            this.numericQRCodeCorrectionLevel.TabIndex = 35;
            this.numericQRCodeCorrectionLevel.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelQRCodeCorrectionLevel
            // 
            this.labelQRCodeCorrectionLevel.Location = new System.Drawing.Point(437, 44);
            this.labelQRCodeCorrectionLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQRCodeCorrectionLevel.Name = "labelQRCodeCorrectionLevel";
            this.labelQRCodeCorrectionLevel.Size = new System.Drawing.Size(116, 33);
            this.labelQRCodeCorrectionLevel.TabIndex = 36;
            this.labelQRCodeCorrectionLevel.Text = "Уровень кор- рекции ошибок:";
            // 
            // labelCompanyUser
            // 
            this.labelCompanyUser.AutoSize = true;
            this.labelCompanyUser.Location = new System.Drawing.Point(9, 128);
            this.labelCompanyUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCompanyUser.Name = "labelCompanyUser";
            this.labelCompanyUser.Size = new System.Drawing.Size(105, 17);
            this.labelCompanyUser.TabIndex = 38;
            this.labelCompanyUser.Text = "Пользователь:";
            // 
            // textCompanyUser
            // 
            this.textCompanyUser.Location = new System.Drawing.Point(120, 125);
            this.textCompanyUser.Margin = new System.Windows.Forms.Padding(4);
            this.textCompanyUser.Name = "textCompanyUser";
            this.textCompanyUser.Size = new System.Drawing.Size(308, 22);
            this.textCompanyUser.TabIndex = 37;
            // 
            // labelFRPlace
            // 
            this.labelFRPlace.AutoSize = true;
            this.labelFRPlace.Location = new System.Drawing.Point(437, 128);
            this.labelFRPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFRPlace.Name = "labelFRPlace";
            this.labelFRPlace.Size = new System.Drawing.Size(53, 17);
            this.labelFRPlace.TabIndex = 40;
            this.labelFRPlace.Text = "Место:";
            // 
            // textFRPlace
            // 
            this.textFRPlace.Location = new System.Drawing.Point(504, 125);
            this.textFRPlace.Margin = new System.Windows.Forms.Padding(4);
            this.textFRPlace.Name = "textFRPlace";
            this.textFRPlace.Size = new System.Drawing.Size(119, 22);
            this.textFRPlace.TabIndex = 39;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(636, 415);
            this.Controls.Add(this.labelFRPlace);
            this.Controls.Add(this.textFRPlace);
            this.Controls.Add(this.labelCompanyUser);
            this.Controls.Add(this.textCompanyUser);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label labelCompanyUser;
        private System.Windows.Forms.TextBox textCompanyUser;
        private System.Windows.Forms.Label labelFRPlace;
        private System.Windows.Forms.TextBox textFRPlace;
    }
}