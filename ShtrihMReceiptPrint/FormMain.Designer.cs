namespace ShtrihMReceiptPrint
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSessionNumber = new System.Windows.Forms.Label();
            this.numericSessionNumber = new System.Windows.Forms.NumericUpDown();
            this.numericCheckNumber = new System.Windows.Forms.NumericUpDown();
            this.labelCheckNumber = new System.Windows.Forms.Label();
            this.numericFiscalDocumentNumber = new System.Windows.Forms.NumericUpDown();
            this.labelFiscalDocumentNumber = new System.Windows.Forms.Label();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusLabelFR = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSessionNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCheckNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiscalDocumentNumber)).BeginInit();
            this.statusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSettings});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(502, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(88, 20);
            this.menuItemSettings.Text = "Настройки...";
            this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
            // 
            // labelSessionNumber
            // 
            this.labelSessionNumber.AutoSize = true;
            this.labelSessionNumber.Location = new System.Drawing.Point(7, 36);
            this.labelSessionNumber.Name = "labelSessionNumber";
            this.labelSessionNumber.Size = new System.Drawing.Size(81, 13);
            this.labelSessionNumber.TabIndex = 1;
            this.labelSessionNumber.Text = "Номер смены:";
            // 
            // numericSessionNumber
            // 
            this.numericSessionNumber.Location = new System.Drawing.Point(94, 34);
            this.numericSessionNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericSessionNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSessionNumber.Name = "numericSessionNumber";
            this.numericSessionNumber.Size = new System.Drawing.Size(80, 20);
            this.numericSessionNumber.TabIndex = 1;
            this.numericSessionNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSessionNumber.Enter += new System.EventHandler(this.numericControls_Enter);
            // 
            // numericCheckNumber
            // 
            this.numericCheckNumber.Location = new System.Drawing.Point(256, 34);
            this.numericCheckNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericCheckNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCheckNumber.Name = "numericCheckNumber";
            this.numericCheckNumber.Size = new System.Drawing.Size(80, 20);
            this.numericCheckNumber.TabIndex = 2;
            this.numericCheckNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCheckNumber.Enter += new System.EventHandler(this.numericControls_Enter);
            // 
            // labelCheckNumber
            // 
            this.labelCheckNumber.AutoSize = true;
            this.labelCheckNumber.Location = new System.Drawing.Point(180, 38);
            this.labelCheckNumber.Name = "labelCheckNumber";
            this.labelCheckNumber.Size = new System.Drawing.Size(70, 13);
            this.labelCheckNumber.TabIndex = 3;
            this.labelCheckNumber.Text = "Номер чека:";
            // 
            // numericFiscalDocumentNumber
            // 
            this.numericFiscalDocumentNumber.Location = new System.Drawing.Point(415, 34);
            this.numericFiscalDocumentNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericFiscalDocumentNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFiscalDocumentNumber.Name = "numericFiscalDocumentNumber";
            this.numericFiscalDocumentNumber.Size = new System.Drawing.Size(80, 20);
            this.numericFiscalDocumentNumber.TabIndex = 3;
            this.numericFiscalDocumentNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericFiscalDocumentNumber.Enter += new System.EventHandler(this.numericControls_Enter);
            // 
            // labelFiscalDocumentNumber
            // 
            this.labelFiscalDocumentNumber.AutoSize = true;
            this.labelFiscalDocumentNumber.Location = new System.Drawing.Point(342, 38);
            this.labelFiscalDocumentNumber.Name = "labelFiscalDocumentNumber";
            this.labelFiscalDocumentNumber.Size = new System.Drawing.Size(67, 13);
            this.labelFiscalDocumentNumber.TabIndex = 5;
            this.labelFiscalDocumentNumber.Text = "Номер ФД:";
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelFR});
            this.statusMain.Location = new System.Drawing.Point(0, 239);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(502, 22);
            this.statusMain.TabIndex = 10;
            this.statusMain.Text = "statusMain";
            // 
            // statusLabelFR
            // 
            this.statusLabelFR.Name = "statusLabelFR";
            this.statusLabelFR.Size = new System.Drawing.Size(172, 17);
            this.statusLabelFR.Text = "Принтер чеков не подключен";
            // 
            // buttonPrint
            // 
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Location = new System.Drawing.Point(370, 3);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(129, 23);
            this.buttonPrint.TabIndex = 7;
            this.buttonPrint.Text = "Выполнить печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProduct,
            this.ColumnQuantity,
            this.ColumnPrice});
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProducts.Location = new System.Drawing.Point(0, 0);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridProducts.ShowEditingIcon = false;
            this.gridProducts.Size = new System.Drawing.Size(502, 148);
            this.gridProducts.TabIndex = 13;
            this.gridProducts.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridProducts_DataError);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonPrint);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 209);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(502, 30);
            this.panelButton.TabIndex = 14;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.gridProducts);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGrid.Location = new System.Drawing.Point(0, 61);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(502, 148);
            this.panelGrid.TabIndex = 15;
            // 
            // ColumnProduct
            // 
            this.ColumnProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnProduct.DataPropertyName = "Description";
            this.ColumnProduct.HeaderText = "Товар";
            this.ColumnProduct.Name = "ColumnProduct";
            this.ColumnProduct.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnQuantity.HeaderText = "Количество";
            this.ColumnQuantity.Name = "ColumnQuantity";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 261);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.numericFiscalDocumentNumber);
            this.Controls.Add(this.labelFiscalDocumentNumber);
            this.Controls.Add(this.numericCheckNumber);
            this.Controls.Add(this.labelCheckNumber);
            this.Controls.Add(this.numericSessionNumber);
            this.Controls.Add(this.labelSessionNumber);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать чеков Штрих-М";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSessionNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCheckNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiscalDocumentNumber)).EndInit();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.Label labelSessionNumber;
        private System.Windows.Forms.NumericUpDown numericSessionNumber;
        private System.Windows.Forms.NumericUpDown numericCheckNumber;
        private System.Windows.Forms.Label labelCheckNumber;
        private System.Windows.Forms.NumericUpDown numericFiscalDocumentNumber;
        private System.Windows.Forms.Label labelFiscalDocumentNumber;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFR;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
    }
}

