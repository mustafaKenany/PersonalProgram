namespace Rresturant.View
{
    partial class PurshaceForm
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
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitla = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.textBoxInvoiceNO = new System.Windows.Forms.TextBox();
            this.textBoxCustomerName = new System.Windows.Forms.TextBox();
            this.buttonNewInvoice = new System.Windows.Forms.Button();
            this.buttonSave_and_Run = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.buttonPausesInvoices = new System.Windows.Forms.Button();
            this.buttonPrintInvoice = new System.Windows.Forms.Button();
            this.textBoxExpireDate = new System.Windows.Forms.TextBox();
            this.textBoxStockQuantity = new System.Windows.Forms.TextBox();
            this.textBoxCriticalRange = new System.Windows.Forms.TextBox();
            this.labelStockQuantity = new System.Windows.Forms.Label();
            this.labelCriticalRange = new System.Windows.Forms.Label();
            this.labelExpireDate = new System.Windows.Forms.Label();
            this.textBoxReminder = new System.Windows.Forms.TextBox();
            this.labelNetAmount = new System.Windows.Forms.Label();
            this.textBoxTotalSaveAmount = new System.Windows.Forms.TextBox();
            this.labelTotalPaid = new System.Windows.Forms.Label();
            this.textBoxPercentageTransfer = new System.Windows.Forms.TextBox();
            this.textBoxDollarSaveAmount = new System.Windows.Forms.TextBox();
            this.labelUSPaid = new System.Windows.Forms.Label();
            this.textBoxLocalSaveAmount = new System.Windows.Forms.TextBox();
            this.labelIQPaid = new System.Windows.Forms.Label();
            this.labelInvoiceTotal = new System.Windows.Forms.Label();
            this.textBoxTotalInvoice = new System.Windows.Forms.TextBox();
            this.radioButtonPercentageDiscount = new System.Windows.Forms.RadioButton();
            this.radioButtonDiscountAmount = new System.Windows.Forms.RadioButton();
            this.textBoxDiscountPercentage = new System.Windows.Forms.TextBox();
            this.textBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.labelPercentageTransfer = new System.Windows.Forms.Label();
            this.textBoxFinalAmount = new System.Windows.Forms.TextBox();
            this.labelReminder = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.listBoxSelectionItems = new System.Windows.Forms.ListBox();
            this.tableLayoutPanelLeftContainer = new System.Windows.Forms.TableLayoutPanel();
            this.labelFilterByNameOrBarCode = new System.Windows.Forms.Label();
            this.labelchooseCat = new System.Windows.Forms.Label();
            this.labelinvoiceNumber = new System.Windows.Forms.Label();
            this.splitContainerSaveAndPause = new System.Windows.Forms.SplitContainer();
            this.labelcustomerName = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelCasherName = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.tableLayoutPanelSummery_Invoice = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.ColumnCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDeletebtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCriticalRange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitla.SuspendLayout();
            this.tableLayoutPanelLeftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaveAndPause)).BeginInit();
            this.splitContainerSaveAndPause.Panel1.SuspendLayout();
            this.splitContainerSaveAndPause.Panel2.SuspendLayout();
            this.splitContainerSaveAndPause.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelSummery_Invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitla
            // 
            this.panelTitla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.panelTitla.Controls.Add(this.labelTitle);
            this.panelTitla.Controls.Add(this.labelExit);
            this.panelTitla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitla.Location = new System.Drawing.Point(4, 4);
            this.panelTitla.Name = "panelTitla";
            this.panelTitla.Padding = new System.Windows.Forms.Padding(2);
            this.panelTitla.Size = new System.Drawing.Size(1242, 40);
            this.panelTitla.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelTitle.Location = new System.Drawing.Point(2, 2);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1208, 36);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "شراء مباشر";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExit
            // 
            this.labelExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelExit.Font = new System.Drawing.Font("Changa Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(1210, 2);
            this.labelExit.Margin = new System.Windows.Forms.Padding(0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(30, 36);
            this.labelExit.TabIndex = 0;
            this.labelExit.Text = "X";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // textBoxInvoiceNO
            // 
            this.textBoxInvoiceNO.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxInvoiceNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInvoiceNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInvoiceNO.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxInvoiceNO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.textBoxInvoiceNO.Location = new System.Drawing.Point(2, 186);
            this.textBoxInvoiceNO.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxInvoiceNO.Multiline = true;
            this.textBoxInvoiceNO.Name = "textBoxInvoiceNO";
            this.textBoxInvoiceNO.ReadOnly = true;
            this.textBoxInvoiceNO.Size = new System.Drawing.Size(246, 35);
            this.textBoxInvoiceNO.TabIndex = 9;
            this.textBoxInvoiceNO.Text = "رقم الفاتورة";
            this.textBoxInvoiceNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCustomerName
            // 
            this.textBoxCustomerName.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCustomerName.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.textBoxCustomerName.Location = new System.Drawing.Point(2, 114);
            this.textBoxCustomerName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCustomerName.Multiline = true;
            this.textBoxCustomerName.Name = "textBoxCustomerName";
            this.textBoxCustomerName.Size = new System.Drawing.Size(246, 35);
            this.textBoxCustomerName.TabIndex = 3;
            this.textBoxCustomerName.Text = "زبون خارجي";
            this.textBoxCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCustomerName.Enter += new System.EventHandler(this.textBoxCustomerName_Enter);
            this.textBoxCustomerName.Leave += new System.EventHandler(this.textBoxCustomerName_Leave);
            // 
            // buttonNewInvoice
            // 
            this.buttonNewInvoice.BackColor = System.Drawing.Color.MintCream;
            this.buttonNewInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNewInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonNewInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.buttonNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewInvoice.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonNewInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonNewInvoice.Location = new System.Drawing.Point(0, 0);
            this.buttonNewInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNewInvoice.Name = "buttonNewInvoice";
            this.buttonNewInvoice.Size = new System.Drawing.Size(121, 75);
            this.buttonNewInvoice.TabIndex = 1;
            this.buttonNewInvoice.Text = "قائمة جديدة";
            this.buttonNewInvoice.UseVisualStyleBackColor = false;
            this.buttonNewInvoice.Click += new System.EventHandler(this.buttonNewInvoice_Click);
            // 
            // buttonSave_and_Run
            // 
            this.buttonSave_and_Run.BackColor = System.Drawing.Color.MintCream;
            this.buttonSave_and_Run.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave_and_Run.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSave_and_Run.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.buttonSave_and_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_and_Run.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonSave_and_Run.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonSave_and_Run.Location = new System.Drawing.Point(116, 6);
            this.buttonSave_and_Run.Name = "buttonSave_and_Run";
            this.buttonSave_and_Run.Size = new System.Drawing.Size(104, 53);
            this.buttonSave_and_Run.TabIndex = 5;
            this.buttonSave_and_Run.Text = "حفظ وترحيل";
            this.buttonSave_and_Run.UseVisualStyleBackColor = false;
            this.buttonSave_and_Run.Click += new System.EventHandler(this.buttonSave_and_Run_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MintCream;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonSave.Location = new System.Drawing.Point(6, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(103, 53);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "حفظ";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerInvoiceDate
            // 
            this.dateTimePickerInvoiceDate.CalendarFont = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerInvoiceDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.dateTimePickerInvoiceDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.dateTimePickerInvoiceDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerInvoiceDate.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInvoiceDate.Location = new System.Drawing.Point(3, 39);
            this.dateTimePickerInvoiceDate.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            this.dateTimePickerInvoiceDate.Size = new System.Drawing.Size(220, 33);
            this.dateTimePickerInvoiceDate.TabIndex = 8;
            // 
            // buttonPausesInvoices
            // 
            this.buttonPausesInvoices.BackColor = System.Drawing.Color.MintCream;
            this.buttonPausesInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPausesInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonPausesInvoices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.buttonPausesInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPausesInvoices.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonPausesInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonPausesInvoices.Location = new System.Drawing.Point(0, 0);
            this.buttonPausesInvoices.Name = "buttonPausesInvoices";
            this.buttonPausesInvoices.Size = new System.Drawing.Size(123, 75);
            this.buttonPausesInvoices.TabIndex = 10;
            this.buttonPausesInvoices.Text = "قوائم معلقة";
            this.buttonPausesInvoices.UseVisualStyleBackColor = false;
            this.buttonPausesInvoices.Click += new System.EventHandler(this.buttonPausesInvoices_Click);
            // 
            // buttonPrintInvoice
            // 
            this.buttonPrintInvoice.BackColor = System.Drawing.Color.MintCream;
            this.buttonPrintInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrintInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonPrintInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.buttonPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintInvoice.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonPrintInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonPrintInvoice.Location = new System.Drawing.Point(6, 66);
            this.buttonPrintInvoice.Name = "buttonPrintInvoice";
            this.buttonPrintInvoice.Size = new System.Drawing.Size(103, 53);
            this.buttonPrintInvoice.TabIndex = 7;
            this.buttonPrintInvoice.Text = "طباعة";
            this.buttonPrintInvoice.UseVisualStyleBackColor = false;
            this.buttonPrintInvoice.Click += new System.EventHandler(this.buttonPrintInvoice_Click);
            // 
            // textBoxExpireDate
            // 
            this.textBoxExpireDate.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxExpireDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExpireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExpireDate.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxExpireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxExpireDate.Location = new System.Drawing.Point(6, 6);
            this.textBoxExpireDate.Multiline = true;
            this.textBoxExpireDate.Name = "textBoxExpireDate";
            this.textBoxExpireDate.ReadOnly = true;
            this.textBoxExpireDate.Size = new System.Drawing.Size(103, 29);
            this.textBoxExpireDate.TabIndex = 10;
            this.textBoxExpireDate.Text = "0";
            this.textBoxExpireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxStockQuantity
            // 
            this.textBoxStockQuantity.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxStockQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStockQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStockQuantity.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxStockQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxStockQuantity.Location = new System.Drawing.Point(6, 78);
            this.textBoxStockQuantity.Multiline = true;
            this.textBoxStockQuantity.Name = "textBoxStockQuantity";
            this.textBoxStockQuantity.ReadOnly = true;
            this.textBoxStockQuantity.Size = new System.Drawing.Size(103, 31);
            this.textBoxStockQuantity.TabIndex = 8;
            this.textBoxStockQuantity.Text = "0";
            this.textBoxStockQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCriticalRange
            // 
            this.textBoxCriticalRange.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxCriticalRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCriticalRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCriticalRange.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxCriticalRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxCriticalRange.Location = new System.Drawing.Point(6, 42);
            this.textBoxCriticalRange.Multiline = true;
            this.textBoxCriticalRange.Name = "textBoxCriticalRange";
            this.textBoxCriticalRange.ReadOnly = true;
            this.textBoxCriticalRange.Size = new System.Drawing.Size(103, 29);
            this.textBoxCriticalRange.TabIndex = 7;
            this.textBoxCriticalRange.Text = "0";
            this.textBoxCriticalRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStockQuantity
            // 
            this.labelStockQuantity.AutoSize = true;
            this.labelStockQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStockQuantity.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelStockQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelStockQuantity.Location = new System.Drawing.Point(116, 78);
            this.labelStockQuantity.Margin = new System.Windows.Forms.Padding(3);
            this.labelStockQuantity.Name = "labelStockQuantity";
            this.labelStockQuantity.Size = new System.Drawing.Size(104, 31);
            this.labelStockQuantity.TabIndex = 4;
            this.labelStockQuantity.Text = "الرصيد المخزني";
            this.labelStockQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCriticalRange
            // 
            this.labelCriticalRange.AutoSize = true;
            this.labelCriticalRange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCriticalRange.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCriticalRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelCriticalRange.Location = new System.Drawing.Point(116, 42);
            this.labelCriticalRange.Margin = new System.Windows.Forms.Padding(3);
            this.labelCriticalRange.Name = "labelCriticalRange";
            this.labelCriticalRange.Size = new System.Drawing.Size(104, 29);
            this.labelCriticalRange.TabIndex = 6;
            this.labelCriticalRange.Text = "الحد الادنى";
            this.labelCriticalRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExpireDate
            // 
            this.labelExpireDate.AutoSize = true;
            this.labelExpireDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExpireDate.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelExpireDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelExpireDate.Location = new System.Drawing.Point(116, 6);
            this.labelExpireDate.Margin = new System.Windows.Forms.Padding(3);
            this.labelExpireDate.Name = "labelExpireDate";
            this.labelExpireDate.Size = new System.Drawing.Size(104, 29);
            this.labelExpireDate.TabIndex = 9;
            this.labelExpireDate.Text = "تاريخ انتهاء الصلاحية";
            this.labelExpireDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReminder
            // 
            this.textBoxReminder.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxReminder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxReminder.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxReminder.Location = new System.Drawing.Point(7, 130);
            this.textBoxReminder.Multiline = true;
            this.textBoxReminder.Name = "textBoxReminder";
            this.textBoxReminder.ReadOnly = true;
            this.textBoxReminder.Size = new System.Drawing.Size(146, 34);
            this.textBoxReminder.TabIndex = 19;
            this.textBoxReminder.Text = "0";
            this.textBoxReminder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNetAmount
            // 
            this.labelNetAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNetAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelNetAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelNetAmount.Location = new System.Drawing.Point(824, 48);
            this.labelNetAmount.Margin = new System.Windows.Forms.Padding(3);
            this.labelNetAmount.Name = "labelNetAmount";
            this.labelNetAmount.Size = new System.Drawing.Size(159, 34);
            this.labelNetAmount.TabIndex = 18;
            this.labelNetAmount.Text = "صافي القائمة";
            this.labelNetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalSaveAmount
            // 
            this.textBoxTotalSaveAmount.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxTotalSaveAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalSaveAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTotalSaveAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxTotalSaveAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxTotalSaveAmount.Location = new System.Drawing.Point(326, 89);
            this.textBoxTotalSaveAmount.Multiline = true;
            this.textBoxTotalSaveAmount.Name = "textBoxTotalSaveAmount";
            this.textBoxTotalSaveAmount.ReadOnly = true;
            this.textBoxTotalSaveAmount.Size = new System.Drawing.Size(159, 34);
            this.textBoxTotalSaveAmount.TabIndex = 17;
            this.textBoxTotalSaveAmount.Text = "0";
            this.textBoxTotalSaveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalPaid
            // 
            this.labelTotalPaid.AutoSize = true;
            this.labelTotalPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalPaid.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTotalPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelTotalPaid.Location = new System.Drawing.Point(492, 89);
            this.labelTotalPaid.Margin = new System.Windows.Forms.Padding(3);
            this.labelTotalPaid.Name = "labelTotalPaid";
            this.labelTotalPaid.Size = new System.Drawing.Size(159, 34);
            this.labelTotalPaid.TabIndex = 16;
            this.labelTotalPaid.Text = "مجموع مبالغ مسددة";
            this.labelTotalPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPercentageTransfer
            // 
            this.textBoxPercentageTransfer.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxPercentageTransfer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPercentageTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPercentageTransfer.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxPercentageTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxPercentageTransfer.Location = new System.Drawing.Point(7, 89);
            this.textBoxPercentageTransfer.Multiline = true;
            this.textBoxPercentageTransfer.Name = "textBoxPercentageTransfer";
            this.textBoxPercentageTransfer.ReadOnly = true;
            this.textBoxPercentageTransfer.Size = new System.Drawing.Size(146, 34);
            this.textBoxPercentageTransfer.TabIndex = 15;
            this.textBoxPercentageTransfer.Text = "0";
            this.textBoxPercentageTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDollarSaveAmount
            // 
            this.textBoxDollarSaveAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDollarSaveAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDollarSaveAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxDollarSaveAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.textBoxDollarSaveAmount.Location = new System.Drawing.Point(7, 48);
            this.textBoxDollarSaveAmount.Multiline = true;
            this.textBoxDollarSaveAmount.Name = "textBoxDollarSaveAmount";
            this.textBoxDollarSaveAmount.Size = new System.Drawing.Size(146, 34);
            this.textBoxDollarSaveAmount.TabIndex = 13;
            this.textBoxDollarSaveAmount.Text = "0";
            this.textBoxDollarSaveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDollarSaveAmount.TextChanged += new System.EventHandler(this.textBoxDollarSaveAmount_TextChanged);
            this.textBoxDollarSaveAmount.Enter += new System.EventHandler(this.textBoxDollarSaveAmount_Enter);
            // 
            // labelUSPaid
            // 
            this.labelUSPaid.AutoSize = true;
            this.labelUSPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUSPaid.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelUSPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelUSPaid.Location = new System.Drawing.Point(160, 48);
            this.labelUSPaid.Margin = new System.Windows.Forms.Padding(3);
            this.labelUSPaid.Name = "labelUSPaid";
            this.labelUSPaid.Size = new System.Drawing.Size(159, 34);
            this.labelUSPaid.TabIndex = 12;
            this.labelUSPaid.Text = "مبلغ مسدد $";
            this.labelUSPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLocalSaveAmount
            // 
            this.textBoxLocalSaveAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLocalSaveAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLocalSaveAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxLocalSaveAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.textBoxLocalSaveAmount.Location = new System.Drawing.Point(326, 48);
            this.textBoxLocalSaveAmount.Multiline = true;
            this.textBoxLocalSaveAmount.Name = "textBoxLocalSaveAmount";
            this.textBoxLocalSaveAmount.Size = new System.Drawing.Size(159, 34);
            this.textBoxLocalSaveAmount.TabIndex = 11;
            this.textBoxLocalSaveAmount.Text = "0";
            this.textBoxLocalSaveAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLocalSaveAmount.TextChanged += new System.EventHandler(this.textBoxLocalSaveAmount_TextChanged);
            this.textBoxLocalSaveAmount.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLocalSaveAmount_MouseDoubleClick);
            // 
            // labelIQPaid
            // 
            this.labelIQPaid.AutoSize = true;
            this.labelIQPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIQPaid.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelIQPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelIQPaid.Location = new System.Drawing.Point(492, 48);
            this.labelIQPaid.Margin = new System.Windows.Forms.Padding(3);
            this.labelIQPaid.Name = "labelIQPaid";
            this.labelIQPaid.Size = new System.Drawing.Size(159, 34);
            this.labelIQPaid.TabIndex = 10;
            this.labelIQPaid.Text = "مبلغ مسدد دينار";
            this.labelIQPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInvoiceTotal
            // 
            this.labelInvoiceTotal.AutoSize = true;
            this.labelInvoiceTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInvoiceTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInvoiceTotal.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelInvoiceTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelInvoiceTotal.Location = new System.Drawing.Point(824, 7);
            this.labelInvoiceTotal.Margin = new System.Windows.Forms.Padding(3);
            this.labelInvoiceTotal.Name = "labelInvoiceTotal";
            this.labelInvoiceTotal.Size = new System.Drawing.Size(159, 34);
            this.labelInvoiceTotal.TabIndex = 2;
            this.labelInvoiceTotal.Text = "مجموع القائمة";
            this.labelInvoiceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTotalInvoice
            // 
            this.textBoxTotalInvoice.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxTotalInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTotalInvoice.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxTotalInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxTotalInvoice.Location = new System.Drawing.Point(658, 7);
            this.textBoxTotalInvoice.Multiline = true;
            this.textBoxTotalInvoice.Name = "textBoxTotalInvoice";
            this.textBoxTotalInvoice.ReadOnly = true;
            this.textBoxTotalInvoice.Size = new System.Drawing.Size(159, 34);
            this.textBoxTotalInvoice.TabIndex = 3;
            this.textBoxTotalInvoice.Text = "مجموع القائمة";
            this.textBoxTotalInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButtonPercentageDiscount
            // 
            this.radioButtonPercentageDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonPercentageDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.radioButtonPercentageDiscount.FlatAppearance.BorderSize = 2;
            this.radioButtonPercentageDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPercentageDiscount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioButtonPercentageDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.radioButtonPercentageDiscount.Location = new System.Drawing.Point(162, 9);
            this.radioButtonPercentageDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonPercentageDiscount.Name = "radioButtonPercentageDiscount";
            this.radioButtonPercentageDiscount.Size = new System.Drawing.Size(155, 30);
            this.radioButtonPercentageDiscount.TabIndex = 4;
            this.radioButtonPercentageDiscount.TabStop = true;
            this.radioButtonPercentageDiscount.Text = "نــــســـبة الــــخصم";
            this.radioButtonPercentageDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPercentageDiscount.UseVisualStyleBackColor = true;
            // 
            // radioButtonDiscountAmount
            // 
            this.radioButtonDiscountAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButtonDiscountAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonDiscountAmount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.radioButtonDiscountAmount.FlatAppearance.BorderSize = 2;
            this.radioButtonDiscountAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonDiscountAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioButtonDiscountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.radioButtonDiscountAmount.Location = new System.Drawing.Point(494, 9);
            this.radioButtonDiscountAmount.Margin = new System.Windows.Forms.Padding(5);
            this.radioButtonDiscountAmount.Name = "radioButtonDiscountAmount";
            this.radioButtonDiscountAmount.Size = new System.Drawing.Size(155, 30);
            this.radioButtonDiscountAmount.TabIndex = 5;
            this.radioButtonDiscountAmount.TabStop = true;
            this.radioButtonDiscountAmount.Text = "مــــبــلغ الــــخصم";
            this.radioButtonDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonDiscountAmount.UseVisualStyleBackColor = true;
            // 
            // textBoxDiscountPercentage
            // 
            this.textBoxDiscountPercentage.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiscountPercentage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscountPercentage.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxDiscountPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.textBoxDiscountPercentage.Location = new System.Drawing.Point(7, 7);
            this.textBoxDiscountPercentage.Multiline = true;
            this.textBoxDiscountPercentage.Name = "textBoxDiscountPercentage";
            this.textBoxDiscountPercentage.Size = new System.Drawing.Size(146, 34);
            this.textBoxDiscountPercentage.TabIndex = 6;
            this.textBoxDiscountPercentage.Text = "0";
            this.textBoxDiscountPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDiscountPercentage.TextChanged += new System.EventHandler(this.textBoxDiscountPercentage_TextChanged);
            // 
            // textBoxDiscountAmount
            // 
            this.textBoxDiscountAmount.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiscountAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscountAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxDiscountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.textBoxDiscountAmount.Location = new System.Drawing.Point(326, 7);
            this.textBoxDiscountAmount.Multiline = true;
            this.textBoxDiscountAmount.Name = "textBoxDiscountAmount";
            this.textBoxDiscountAmount.Size = new System.Drawing.Size(159, 34);
            this.textBoxDiscountAmount.TabIndex = 7;
            this.textBoxDiscountAmount.Text = "0";
            this.textBoxDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDiscountAmount.TextChanged += new System.EventHandler(this.textBoxDiscountAmount_TextChanged);
            // 
            // labelPercentageTransfer
            // 
            this.labelPercentageTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPercentageTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPercentageTransfer.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelPercentageTransfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelPercentageTransfer.Location = new System.Drawing.Point(160, 89);
            this.labelPercentageTransfer.Margin = new System.Windows.Forms.Padding(3);
            this.labelPercentageTransfer.Name = "labelPercentageTransfer";
            this.labelPercentageTransfer.Size = new System.Drawing.Size(159, 34);
            this.labelPercentageTransfer.TabIndex = 14;
            this.labelPercentageTransfer.Text = "نسبة تحويل الدولار";
            this.labelPercentageTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFinalAmount
            // 
            this.textBoxFinalAmount.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxFinalAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFinalAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFinalAmount.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxFinalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxFinalAmount.Location = new System.Drawing.Point(658, 48);
            this.textBoxFinalAmount.Multiline = true;
            this.textBoxFinalAmount.Name = "textBoxFinalAmount";
            this.textBoxFinalAmount.ReadOnly = true;
            this.textBoxFinalAmount.Size = new System.Drawing.Size(159, 34);
            this.textBoxFinalAmount.TabIndex = 9;
            this.textBoxFinalAmount.Text = "صافي القائمة";
            this.textBoxFinalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelReminder
            // 
            this.labelReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReminder.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelReminder.Location = new System.Drawing.Point(160, 130);
            this.labelReminder.Margin = new System.Windows.Forms.Padding(3);
            this.labelReminder.Name = "labelReminder";
            this.labelReminder.Size = new System.Drawing.Size(159, 34);
            this.labelReminder.TabIndex = 8;
            this.labelReminder.Text = "مبلغ متبقي";
            this.labelReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBarCode.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxBarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxBarCode.Location = new System.Drawing.Point(2, 330);
            this.textBoxBarCode.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBarCode.Multiline = true;
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(246, 35);
            this.textBoxBarCode.TabIndex = 2;
            this.textBoxBarCode.Text = "ادخل باركود او اسم المادة";
            this.textBoxBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBarCode.TextChanged += new System.EventHandler(this.textBoxBarCode_TextChanged);
            this.textBoxBarCode.Enter += new System.EventHandler(this.textBoxBarCode_Enter);
            this.textBoxBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarCode_KeyDown);
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.comboBoxCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.ItemHeight = 26;
            this.comboBoxCategories.Location = new System.Drawing.Point(2, 258);
            this.comboBoxCategories.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxCategories.Size = new System.Drawing.Size(246, 34);
            this.comboBoxCategories.TabIndex = 9;
            this.comboBoxCategories.DropDown += new System.EventHandler(this.comboBoxCategories_DropDown);
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // listBoxSelectionItems
            // 
            this.listBoxSelectionItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSelectionItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSelectionItems.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.listBoxSelectionItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.listBoxSelectionItems.FormattingEnabled = true;
            this.listBoxSelectionItems.ItemHeight = 26;
            this.listBoxSelectionItems.Location = new System.Drawing.Point(2, 366);
            this.listBoxSelectionItems.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxSelectionItems.Name = "listBoxSelectionItems";
            this.listBoxSelectionItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxSelectionItems.ScrollAlwaysVisible = true;
            this.listBoxSelectionItems.Size = new System.Drawing.Size(246, 310);
            this.listBoxSelectionItems.TabIndex = 11;
            this.listBoxSelectionItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxSelectionItems_MouseDoubleClick);
            // 
            // tableLayoutPanelLeftContainer
            // 
            this.tableLayoutPanelLeftContainer.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanelLeftContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelLeftContainer.ColumnCount = 1;
            this.tableLayoutPanelLeftContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelLeftContainer.Controls.Add(this.listBoxSelectionItems, 0, 9);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.labelFilterByNameOrBarCode, 0, 7);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.textBoxBarCode, 0, 8);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.labelchooseCat, 0, 5);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.textBoxInvoiceNO, 0, 4);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.labelinvoiceNumber, 0, 3);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.splitContainerSaveAndPause, 0, 0);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.textBoxCustomerName, 0, 2);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.labelcustomerName, 0, 1);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.comboBoxCategories, 0, 6);
            this.tableLayoutPanelLeftContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelLeftContainer.Location = new System.Drawing.Point(996, 44);
            this.tableLayoutPanelLeftContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelLeftContainer.Name = "tableLayoutPanelLeftContainer";
            this.tableLayoutPanelLeftContainer.Padding = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanelLeftContainer.RowCount = 10;
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLeftContainer.Size = new System.Drawing.Size(250, 678);
            this.tableLayoutPanelLeftContainer.TabIndex = 2;
            // 
            // labelFilterByNameOrBarCode
            // 
            this.labelFilterByNameOrBarCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFilterByNameOrBarCode.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelFilterByNameOrBarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelFilterByNameOrBarCode.Location = new System.Drawing.Point(2, 294);
            this.labelFilterByNameOrBarCode.Margin = new System.Windows.Forms.Padding(0);
            this.labelFilterByNameOrBarCode.Name = "labelFilterByNameOrBarCode";
            this.labelFilterByNameOrBarCode.Size = new System.Drawing.Size(246, 35);
            this.labelFilterByNameOrBarCode.TabIndex = 11;
            this.labelFilterByNameOrBarCode.Text = "البحث بوساطة باركود او الاسم";
            this.labelFilterByNameOrBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelchooseCat
            // 
            this.labelchooseCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelchooseCat.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelchooseCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelchooseCat.Location = new System.Drawing.Point(2, 222);
            this.labelchooseCat.Margin = new System.Windows.Forms.Padding(0);
            this.labelchooseCat.Name = "labelchooseCat";
            this.labelchooseCat.Size = new System.Drawing.Size(246, 35);
            this.labelchooseCat.TabIndex = 10;
            this.labelchooseCat.Text = "اختيار الصنف";
            this.labelchooseCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelinvoiceNumber
            // 
            this.labelinvoiceNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelinvoiceNumber.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelinvoiceNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelinvoiceNumber.Location = new System.Drawing.Point(2, 150);
            this.labelinvoiceNumber.Margin = new System.Windows.Forms.Padding(0);
            this.labelinvoiceNumber.Name = "labelinvoiceNumber";
            this.labelinvoiceNumber.Size = new System.Drawing.Size(246, 35);
            this.labelinvoiceNumber.TabIndex = 1;
            this.labelinvoiceNumber.Text = "رقم القائمة";
            this.labelinvoiceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainerSaveAndPause
            // 
            this.splitContainerSaveAndPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSaveAndPause.Location = new System.Drawing.Point(2, 2);
            this.splitContainerSaveAndPause.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainerSaveAndPause.Name = "splitContainerSaveAndPause";
            // 
            // splitContainerSaveAndPause.Panel1
            // 
            this.splitContainerSaveAndPause.Panel1.Controls.Add(this.buttonPausesInvoices);
            // 
            // splitContainerSaveAndPause.Panel2
            // 
            this.splitContainerSaveAndPause.Panel2.Controls.Add(this.buttonNewInvoice);
            this.splitContainerSaveAndPause.Size = new System.Drawing.Size(246, 75);
            this.splitContainerSaveAndPause.SplitterDistance = 123;
            this.splitContainerSaveAndPause.SplitterWidth = 2;
            this.splitContainerSaveAndPause.TabIndex = 0;
            // 
            // labelcustomerName
            // 
            this.labelcustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelcustomerName.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelcustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelcustomerName.Location = new System.Drawing.Point(2, 78);
            this.labelcustomerName.Margin = new System.Windows.Forms.Padding(0);
            this.labelcustomerName.Name = "labelcustomerName";
            this.labelcustomerName.Size = new System.Drawing.Size(246, 35);
            this.labelcustomerName.TabIndex = 0;
            this.labelcustomerName.Text = "أسم الزبون";
            this.labelcustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserName.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.textBoxUserName.Location = new System.Drawing.Point(3, 111);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxUserName.Multiline = true;
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(220, 36);
            this.textBoxUserName.TabIndex = 13;
            this.textBoxUserName.Text = "محاسب";
            this.textBoxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCasherName
            // 
            this.labelCasherName.AutoSize = true;
            this.labelCasherName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCasherName.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCasherName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelCasherName.Location = new System.Drawing.Point(6, 78);
            this.labelCasherName.Margin = new System.Windows.Forms.Padding(3);
            this.labelCasherName.Name = "labelCasherName";
            this.labelCasherName.Size = new System.Drawing.Size(214, 29);
            this.labelCasherName.TabIndex = 12;
            this.labelCasherName.Text = "أسم المحاسب";
            this.labelCasherName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Controls.Add(this.panelRight);
            this.panelContainer.Controls.Add(this.tableLayoutPanelSummery_Invoice);
            this.panelContainer.Controls.Add(this.dataGridViewItems);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(4, 44);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(1);
            this.panelContainer.Size = new System.Drawing.Size(992, 678);
            this.panelContainer.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelRight.Controls.Add(this.tableLayoutPanel4);
            this.panelRight.Controls.Add(this.tableLayoutPanel3);
            this.panelRight.Controls.Add(this.tableLayoutPanel1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRight.Location = new System.Drawing.Point(1, 1);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(2);
            this.panelRight.Size = new System.Drawing.Size(234, 509);
            this.panelRight.TabIndex = 21;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonCancel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonSave_and_Run, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonSave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonPrintInvoice, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 378);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(226, 125);
            this.tableLayoutPanel4.TabIndex = 22;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.MintCream;
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonCancel.Location = new System.Drawing.Point(116, 66);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 53);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "الغاء";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelExpireDate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelCriticalRange, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxStockQuantity, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxExpireDate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxCriticalRange, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelStockQuantity, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 152);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(226, 115);
            this.tableLayoutPanel3.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelInvoiceDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerInvoiceDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelCasherName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUserName, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 150);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInvoiceDate.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelInvoiceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelInvoiceDate.Location = new System.Drawing.Point(6, 6);
            this.labelInvoiceDate.Margin = new System.Windows.Forms.Padding(3);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(214, 29);
            this.labelInvoiceDate.TabIndex = 22;
            this.labelInvoiceDate.Text = "تاريخ القائمة";
            this.labelInvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelSummery_Invoice
            // 
            this.tableLayoutPanelSummery_Invoice.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelSummery_Invoice.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelSummery_Invoice.ColumnCount = 6;
            this.tableLayoutPanelSummery_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanelSummery_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanelSummery_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanelSummery_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanelSummery_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanelSummery_Invoice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.textBoxTotalInvoice, 1, 0);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.radioButtonDiscountAmount, 2, 0);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.labelInvoiceTotal, 0, 0);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.radioButtonPercentageDiscount, 4, 0);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.textBoxDiscountAmount, 3, 0);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.textBoxDiscountPercentage, 5, 0);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.labelUSPaid, 4, 1);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.labelIQPaid, 2, 1);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.labelNetAmount, 0, 1);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.textBoxFinalAmount, 1, 1);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.textBoxLocalSaveAmount, 3, 1);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.textBoxDollarSaveAmount, 5, 1);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.textBoxReminder, 5, 3);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.labelTotalPaid, 2, 2);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.textBoxPercentageTransfer, 5, 2);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.labelReminder, 4, 3);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.textBoxTotalSaveAmount, 3, 2);
            this.tableLayoutPanelSummery_Invoice.Controls.Add(this.labelPercentageTransfer, 4, 2);
            this.tableLayoutPanelSummery_Invoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelSummery_Invoice.Location = new System.Drawing.Point(1, 510);
            this.tableLayoutPanelSummery_Invoice.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelSummery_Invoice.Name = "tableLayoutPanelSummery_Invoice";
            this.tableLayoutPanelSummery_Invoice.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanelSummery_Invoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanelSummery_Invoice.RowCount = 4;
            this.tableLayoutPanelSummery_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSummery_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSummery_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSummery_Invoice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelSummery_Invoice.Size = new System.Drawing.Size(990, 167);
            this.tableLayoutPanelSummery_Invoice.TabIndex = 2;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToAddRows = false;
            this.dataGridViewItems.AllowUserToDeleteRows = false;
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridViewItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCounter,
            this.ColumnItemName,
            this.ColumnItemQuantity,
            this.ColumnItemPrice,
            this.ColumnTotal,
            this.ColumnDeletebtn,
            this.ColumnExpireDate,
            this.ColumnStockQuantity,
            this.ColumnCriticalRange});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.dataGridViewItems.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewItems.MultiSelect = false;
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.RowHeadersWidth = 50;
            this.dataGridViewItems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewItems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridViewItems.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.dataGridViewItems.RowTemplate.Height = 40;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(990, 676);
            this.dataGridViewItems.TabIndex = 9;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick_1);
            this.dataGridViewItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellValueChanged_1);
            this.dataGridViewItems.SelectionChanged += new System.EventHandler(this.dataGridViewItems_SelectionChanged_1);
            // 
            // ColumnCounter
            // 
            this.ColumnCounter.HeaderText = "تسلسل";
            this.ColumnCounter.Name = "ColumnCounter";
            this.ColumnCounter.ReadOnly = true;
            this.ColumnCounter.Width = 75;
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.HeaderText = "أسم المادة";
            this.ColumnItemName.Name = "ColumnItemName";
            this.ColumnItemName.ReadOnly = true;
            this.ColumnItemName.Width = 200;
            // 
            // ColumnItemQuantity
            // 
            this.ColumnItemQuantity.HeaderText = "الكمية";
            this.ColumnItemQuantity.Name = "ColumnItemQuantity";
            // 
            // ColumnItemPrice
            // 
            this.ColumnItemPrice.HeaderText = "السعر";
            this.ColumnItemPrice.Name = "ColumnItemPrice";
            this.ColumnItemPrice.Width = 125;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "المجموع";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            this.ColumnTotal.Width = 175;
            // 
            // ColumnDeletebtn
            // 
            this.ColumnDeletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnDeletebtn.HeaderText = "حذف";
            this.ColumnDeletebtn.Name = "ColumnDeletebtn";
            this.ColumnDeletebtn.Text = "حذف";
            this.ColumnDeletebtn.UseColumnTextForButtonValue = true;
            this.ColumnDeletebtn.Width = 75;
            // 
            // ColumnExpireDate
            // 
            this.ColumnExpireDate.HeaderText = "تاريخ الصلاحية";
            this.ColumnExpireDate.Name = "ColumnExpireDate";
            this.ColumnExpireDate.Visible = false;
            // 
            // ColumnStockQuantity
            // 
            this.ColumnStockQuantity.HeaderText = "الرصيد المخزني";
            this.ColumnStockQuantity.Name = "ColumnStockQuantity";
            this.ColumnStockQuantity.Visible = false;
            // 
            // ColumnCriticalRange
            // 
            this.ColumnCriticalRange.HeaderText = "الرصيد الحرج";
            this.ColumnCriticalRange.Name = "ColumnCriticalRange";
            this.ColumnCriticalRange.Visible = false;
            // 
            // PurshaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1250, 726);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.tableLayoutPanelLeftContainer);
            this.Controls.Add(this.panelTitla);
            this.Font = new System.Drawing.Font("Changa Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(225, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MinimumSize = new System.Drawing.Size(1250, 726);
            this.Name = "PurshaceForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PurshaceForm";
            this.Activated += new System.EventHandler(this.PurshaceForm_Activated);
            this.panelTitla.ResumeLayout(false);
            this.tableLayoutPanelLeftContainer.ResumeLayout(false);
            this.tableLayoutPanelLeftContainer.PerformLayout();
            this.splitContainerSaveAndPause.Panel1.ResumeLayout(false);
            this.splitContainerSaveAndPause.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSaveAndPause)).EndInit();
            this.splitContainerSaveAndPause.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelSummery_Invoice.ResumeLayout(false);
            this.tableLayoutPanelSummery_Invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitla;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Button buttonNewInvoice;
        private System.Windows.Forms.Button buttonSave_and_Run;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPrintInvoice;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoiceDate;
        private System.Windows.Forms.TextBox textBoxInvoiceNO;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.TextBox textBoxTotalSaveAmount;
        private System.Windows.Forms.Label labelTotalPaid;
        private System.Windows.Forms.TextBox textBoxPercentageTransfer;
        private System.Windows.Forms.Label labelPercentageTransfer;
        private System.Windows.Forms.TextBox textBoxDollarSaveAmount;
        private System.Windows.Forms.Label labelUSPaid;
        private System.Windows.Forms.TextBox textBoxLocalSaveAmount;
        private System.Windows.Forms.Label labelIQPaid;
        private System.Windows.Forms.Label labelInvoiceTotal;
        private System.Windows.Forms.TextBox textBoxTotalInvoice;
        private System.Windows.Forms.RadioButton radioButtonPercentageDiscount;
        private System.Windows.Forms.RadioButton radioButtonDiscountAmount;
        private System.Windows.Forms.TextBox textBoxDiscountPercentage;
        private System.Windows.Forms.TextBox textBoxDiscountAmount;
        private System.Windows.Forms.Label labelReminder;
        private System.Windows.Forms.TextBox textBoxFinalAmount;
        private System.Windows.Forms.Label labelStockQuantity;
        private System.Windows.Forms.Label labelCriticalRange;
        private System.Windows.Forms.TextBox textBoxCriticalRange;
        private System.Windows.Forms.TextBox textBoxStockQuantity;
        private System.Windows.Forms.TextBox textBoxExpireDate;
        private System.Windows.Forms.Label labelExpireDate;
        private System.Windows.Forms.TextBox textBoxReminder;
        private System.Windows.Forms.Label labelNetAmount;
        private System.Windows.Forms.ListBox listBoxSelectionItems;
        private System.Windows.Forms.Button buttonPausesInvoices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftContainer;
        private System.Windows.Forms.SplitContainer splitContainerSaveAndPause;
        private System.Windows.Forms.Label labelinvoiceNumber;
        private System.Windows.Forms.Label labelcustomerName;
        private System.Windows.Forms.Label labelchooseCat;
        private System.Windows.Forms.Label labelFilterByNameOrBarCode;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelCasherName;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSummery_Invoice;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDeletebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCriticalRange;
        private System.Windows.Forms.Button buttonCancel;
    }
}