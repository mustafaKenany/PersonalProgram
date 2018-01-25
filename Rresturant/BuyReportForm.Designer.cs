namespace Rresturant
{
    partial class BuyReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearchFilter = new System.Windows.Forms.Label();
            this.textBoxFilterBuyGrid = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonShowBuyInvoices = new System.Windows.Forms.Button();
            this.buttonPrintBuyGrid = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.labelToDate = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDateSearch = new System.Windows.Forms.CheckBox();
            this.dataGridViewBuyGridInvoice = new System.Windows.Forms.DataGridView();
            this.ColumnInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceRunORNot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInvoiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIQPAid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUSPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReminder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButtonDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuyGridInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.labelTitleForm);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 40);
            this.panel1.TabIndex = 3;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleForm.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelTitleForm.Location = new System.Drawing.Point(0, 0);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(1072, 40);
            this.labelTitleForm.TabIndex = 3;
            this.labelTitleForm.Text = "فواتير البيع";
            this.labelTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1072, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(43, 40);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.checkBoxDateSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 45);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(1115, 75);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.labelSearchFilter, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxFilterBuyGrid, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(350, 69);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // labelSearchFilter
            // 
            this.labelSearchFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSearchFilter.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelSearchFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelSearchFilter.Location = new System.Drawing.Point(0, 0);
            this.labelSearchFilter.Margin = new System.Windows.Forms.Padding(0);
            this.labelSearchFilter.Name = "labelSearchFilter";
            this.labelSearchFilter.Size = new System.Drawing.Size(350, 34);
            this.labelSearchFilter.TabIndex = 5;
            this.labelSearchFilter.Text = "ادخل كلمة للبحث";
            this.labelSearchFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFilterBuyGrid
            // 
            this.textBoxFilterBuyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilterBuyGrid.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxFilterBuyGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.textBoxFilterBuyGrid.Location = new System.Drawing.Point(0, 34);
            this.textBoxFilterBuyGrid.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxFilterBuyGrid.Multiline = true;
            this.textBoxFilterBuyGrid.Name = "textBoxFilterBuyGrid";
            this.textBoxFilterBuyGrid.Size = new System.Drawing.Size(350, 35);
            this.textBoxFilterBuyGrid.TabIndex = 4;
            this.textBoxFilterBuyGrid.Text = "هنا";
            this.textBoxFilterBuyGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFilterBuyGrid.TextChanged += new System.EventHandler(this.textBoxFilterBuyGrid_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonShowBuyInvoices, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonPrintBuyGrid, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(539, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 69);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // buttonShowBuyInvoices
            // 
            this.buttonShowBuyInvoices.AutoSize = true;
            this.buttonShowBuyInvoices.BackColor = System.Drawing.Color.White;
            this.buttonShowBuyInvoices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowBuyInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonShowBuyInvoices.FlatAppearance.BorderSize = 2;
            this.buttonShowBuyInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowBuyInvoices.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonShowBuyInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonShowBuyInvoices.Location = new System.Drawing.Point(110, 0);
            this.buttonShowBuyInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowBuyInvoices.Name = "buttonShowBuyInvoices";
            this.buttonShowBuyInvoices.Size = new System.Drawing.Size(90, 69);
            this.buttonShowBuyInvoices.TabIndex = 1;
            this.buttonShowBuyInvoices.Text = "عرض الفواتير";
            this.buttonShowBuyInvoices.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonShowBuyInvoices.UseVisualStyleBackColor = false;
            this.buttonShowBuyInvoices.Click += new System.EventHandler(this.buttonShowBuyInvoices_Click);
            // 
            // buttonPrintBuyGrid
            // 
            this.buttonPrintBuyGrid.AutoSize = true;
            this.buttonPrintBuyGrid.BackColor = System.Drawing.Color.White;
            this.buttonPrintBuyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrintBuyGrid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonPrintBuyGrid.FlatAppearance.BorderSize = 2;
            this.buttonPrintBuyGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintBuyGrid.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonPrintBuyGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonPrintBuyGrid.Location = new System.Drawing.Point(0, 0);
            this.buttonPrintBuyGrid.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrintBuyGrid.Name = "buttonPrintBuyGrid";
            this.buttonPrintBuyGrid.Size = new System.Drawing.Size(90, 69);
            this.buttonPrintBuyGrid.TabIndex = 2;
            this.buttonPrintBuyGrid.Text = "طباعة";
            this.buttonPrintBuyGrid.UseVisualStyleBackColor = false;
            this.buttonPrintBuyGrid.Click += new System.EventHandler(this.buttonPrintBuyGrid_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.labelFromDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelToDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerTo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerFrom, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(739, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(266, 69);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFromDate.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelFromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelFromDate.Location = new System.Drawing.Point(217, 0);
            this.labelFromDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(49, 34);
            this.labelFromDate.TabIndex = 11;
            this.labelFromDate.Text = "من";
            // 
            // labelToDate
            // 
            this.labelToDate.AutoSize = true;
            this.labelToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelToDate.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelToDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelToDate.Location = new System.Drawing.Point(217, 34);
            this.labelToDate.Margin = new System.Windows.Forms.Padding(0);
            this.labelToDate.Name = "labelToDate";
            this.labelToDate.Size = new System.Drawing.Size(49, 35);
            this.labelToDate.TabIndex = 12;
            this.labelToDate.Text = "الى";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerTo.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(21, 34);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(196, 33);
            this.dateTimePickerTo.TabIndex = 10;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(21, 0);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(196, 33);
            this.dateTimePickerFrom.TabIndex = 9;
            // 
            // checkBoxDateSearch
            // 
            this.checkBoxDateSearch.AutoSize = true;
            this.checkBoxDateSearch.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxDateSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBoxDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDateSearch.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.checkBoxDateSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.checkBoxDateSearch.Location = new System.Drawing.Point(1005, 3);
            this.checkBoxDateSearch.Name = "checkBoxDateSearch";
            this.checkBoxDateSearch.Size = new System.Drawing.Size(107, 69);
            this.checkBoxDateSearch.TabIndex = 13;
            this.checkBoxDateSearch.Text = "بحث بين تاريخين";
            this.checkBoxDateSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxDateSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuyGridInvoice
            // 
            this.dataGridViewBuyGridInvoice.AllowUserToAddRows = false;
            this.dataGridViewBuyGridInvoice.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBuyGridInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBuyGridInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBuyGridInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBuyGridInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewBuyGridInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Changa Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBuyGridInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBuyGridInvoice.ColumnHeadersHeight = 50;
            this.dataGridViewBuyGridInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnInvoiceNo,
            this.ColumnInvoiceCustomer,
            this.ColumnInvoiceTotal,
            this.ColumnInvoiceDiscount,
            this.ColumnInvoiceTotalAmount,
            this.ColumnInvoiceStatus,
            this.ColumnInvoiceDate,
            this.ColumnInvoiceRunORNot,
            this.ColumnInvoiceType,
            this.ColumnIQPAid,
            this.ColumnUSPaid,
            this.ColumnConversionRate,
            this.ColumnReminder,
            this.ColumnButtonDetails});
            this.dataGridViewBuyGridInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBuyGridInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.dataGridViewBuyGridInvoice.Location = new System.Drawing.Point(5, 120);
            this.dataGridViewBuyGridInvoice.MultiSelect = false;
            this.dataGridViewBuyGridInvoice.Name = "dataGridViewBuyGridInvoice";
            this.dataGridViewBuyGridInvoice.ReadOnly = true;
            this.dataGridViewBuyGridInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewBuyGridInvoice.RowHeadersVisible = false;
            this.dataGridViewBuyGridInvoice.RowHeadersWidth = 45;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBuyGridInvoice.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBuyGridInvoice.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewBuyGridInvoice.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridViewBuyGridInvoice.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBuyGridInvoice.RowTemplate.Height = 40;
            this.dataGridViewBuyGridInvoice.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBuyGridInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuyGridInvoice.Size = new System.Drawing.Size(1115, 575);
            this.dataGridViewBuyGridInvoice.TabIndex = 11;
            this.dataGridViewBuyGridInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuyGridInvoice_CellContentClick);
            // 
            // ColumnInvoiceNo
            // 
            this.ColumnInvoiceNo.DataPropertyName = "invoiceNo";
            this.ColumnInvoiceNo.HeaderText = "رقم فاتورة";
            this.ColumnInvoiceNo.Name = "ColumnInvoiceNo";
            this.ColumnInvoiceNo.ReadOnly = true;
            // 
            // ColumnInvoiceCustomer
            // 
            this.ColumnInvoiceCustomer.DataPropertyName = "CustomerName";
            this.ColumnInvoiceCustomer.HeaderText = "الـــــزبــــــــون";
            this.ColumnInvoiceCustomer.Name = "ColumnInvoiceCustomer";
            this.ColumnInvoiceCustomer.ReadOnly = true;
            this.ColumnInvoiceCustomer.Width = 200;
            // 
            // ColumnInvoiceTotal
            // 
            this.ColumnInvoiceTotal.DataPropertyName = "InvoiceTotalAmount";
            this.ColumnInvoiceTotal.HeaderText = "مجموع فاتورة";
            this.ColumnInvoiceTotal.Name = "ColumnInvoiceTotal";
            this.ColumnInvoiceTotal.ReadOnly = true;
            // 
            // ColumnInvoiceDiscount
            // 
            this.ColumnInvoiceDiscount.DataPropertyName = "InvoiceDiscount";
            this.ColumnInvoiceDiscount.HeaderText = "خصم القائمة";
            this.ColumnInvoiceDiscount.Name = "ColumnInvoiceDiscount";
            this.ColumnInvoiceDiscount.ReadOnly = true;
            // 
            // ColumnInvoiceTotalAmount
            // 
            this.ColumnInvoiceTotalAmount.DataPropertyName = "InvoiceNetAmount";
            this.ColumnInvoiceTotalAmount.HeaderText = "صافي القائمة";
            this.ColumnInvoiceTotalAmount.Name = "ColumnInvoiceTotalAmount";
            this.ColumnInvoiceTotalAmount.ReadOnly = true;
            // 
            // ColumnInvoiceStatus
            // 
            this.ColumnInvoiceStatus.DataPropertyName = "InvoicePaymentStatus";
            this.ColumnInvoiceStatus.HeaderText = "نوع فاتورة";
            this.ColumnInvoiceStatus.Name = "ColumnInvoiceStatus";
            this.ColumnInvoiceStatus.ReadOnly = true;
            // 
            // ColumnInvoiceDate
            // 
            this.ColumnInvoiceDate.DataPropertyName = "InvoiceDate";
            this.ColumnInvoiceDate.HeaderText = "تاريخ فاتورة";
            this.ColumnInvoiceDate.Name = "ColumnInvoiceDate";
            this.ColumnInvoiceDate.ReadOnly = true;
            // 
            // ColumnInvoiceRunORNot
            // 
            this.ColumnInvoiceRunORNot.DataPropertyName = "InvoiceRunORnot";
            this.ColumnInvoiceRunORNot.HeaderText = "RUNORNOT";
            this.ColumnInvoiceRunORNot.Name = "ColumnInvoiceRunORNot";
            this.ColumnInvoiceRunORNot.ReadOnly = true;
            this.ColumnInvoiceRunORNot.Visible = false;
            // 
            // ColumnInvoiceType
            // 
            this.ColumnInvoiceType.DataPropertyName = "InvoiceType";
            this.ColumnInvoiceType.HeaderText = "INVOICETYPE";
            this.ColumnInvoiceType.Name = "ColumnInvoiceType";
            this.ColumnInvoiceType.ReadOnly = true;
            this.ColumnInvoiceType.Visible = false;
            // 
            // ColumnIQPAid
            // 
            this.ColumnIQPAid.DataPropertyName = "IQAmountPaid";
            this.ColumnIQPAid.HeaderText = "مبلغ عراقي";
            this.ColumnIQPAid.Name = "ColumnIQPAid";
            this.ColumnIQPAid.ReadOnly = true;
            // 
            // ColumnUSPaid
            // 
            this.ColumnUSPaid.DataPropertyName = "USAmountPaid";
            this.ColumnUSPaid.HeaderText = "مبلغ دولار";
            this.ColumnUSPaid.Name = "ColumnUSPaid";
            this.ColumnUSPaid.ReadOnly = true;
            // 
            // ColumnConversionRate
            // 
            this.ColumnConversionRate.DataPropertyName = "ConversionRate";
            this.ColumnConversionRate.HeaderText = "نسبة تحويل";
            this.ColumnConversionRate.Name = "ColumnConversionRate";
            this.ColumnConversionRate.ReadOnly = true;
            // 
            // ColumnReminder
            // 
            this.ColumnReminder.DataPropertyName = "Reminder";
            this.ColumnReminder.HeaderText = "المتبقي";
            this.ColumnReminder.Name = "ColumnReminder";
            this.ColumnReminder.ReadOnly = true;
            // 
            // ColumnButtonDetails
            // 
            this.ColumnButtonDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnButtonDetails.HeaderText = "التفاصيل";
            this.ColumnButtonDetails.Name = "ColumnButtonDetails";
            this.ColumnButtonDetails.ReadOnly = true;
            this.ColumnButtonDetails.Text = "عرض";
            this.ColumnButtonDetails.UseColumnTextForButtonValue = true;
            // 
            // BuyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1125, 700);
            this.Controls.Add(this.dataGridViewBuyGridInvoice);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 12);
            this.Name = "BuyReportForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuyGridInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonShowBuyInvoices;
        private System.Windows.Forms.Button buttonPrintBuyGrid;
        private System.Windows.Forms.Label labelSearchFilter;
        private System.Windows.Forms.TextBox textBoxFilterBuyGrid;
        private System.Windows.Forms.CheckBox checkBoxDateSearch;
        private System.Windows.Forms.Label labelToDate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DataGridView dataGridViewBuyGridInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceRunORNot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIQPAid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUSPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReminder;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButtonDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}