namespace Rresturant
{
    partial class PaidGetMoney
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelFormTitle = new System.Windows.Forms.Panel();
            this.labelEXT = new System.Windows.Forms.Label();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.panelUpperContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanelDateContain = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerTransaction = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelUpperControl = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSaveTransaction = new System.Windows.Forms.Button();
            this.buttonDeleteallTransaction = new System.Windows.Forms.Button();
            this.buttonNewTransaction = new System.Windows.Forms.Button();
            this.buttonModifeTransaction = new System.Windows.Forms.Button();
            this.panelRightControl = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.tableLayoutPanelRightContainer = new System.Windows.Forms.TableLayoutPanel();
            this.buttondeleteTransaction = new System.Windows.Forms.Button();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewMoney = new System.Windows.Forms.DataGridView();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.ColumnTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnmoneyType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnMoneyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTansferPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCutomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrintTransaction = new System.Windows.Forms.Button();
            this.buttonPrintallTransaction = new System.Windows.Forms.Button();
            this.tableLayoutPanelCustomer = new System.Windows.Forms.TableLayoutPanel();
            this.labelCutomerTotal = new System.Windows.Forms.Label();
            this.textBoxCutomerTotal = new System.Windows.Forms.TextBox();
            this.panelFormTitle.SuspendLayout();
            this.panelUpperContainer.SuspendLayout();
            this.tableLayoutPanelDateContain.SuspendLayout();
            this.tableLayoutPanelUpperControl.SuspendLayout();
            this.panelRightControl.SuspendLayout();
            this.tableLayoutPanelRightContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoney)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.tableLayoutPanelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFormTitle
            // 
            this.panelFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.panelFormTitle.Controls.Add(this.labelEXT);
            this.panelFormTitle.Controls.Add(this.labelTitleForm);
            this.panelFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormTitle.Location = new System.Drawing.Point(5, 5);
            this.panelFormTitle.Margin = new System.Windows.Forms.Padding(0);
            this.panelFormTitle.Name = "panelFormTitle";
            this.panelFormTitle.Size = new System.Drawing.Size(1240, 40);
            this.panelFormTitle.TabIndex = 1;
            // 
            // labelEXT
            // 
            this.labelEXT.AutoSize = true;
            this.labelEXT.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEXT.Font = new System.Drawing.Font("Changa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelEXT.ForeColor = System.Drawing.Color.White;
            this.labelEXT.Location = new System.Drawing.Point(1211, 0);
            this.labelEXT.Name = "labelEXT";
            this.labelEXT.Size = new System.Drawing.Size(29, 37);
            this.labelEXT.TabIndex = 1;
            this.labelEXT.Text = "X";
            this.labelEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEXT.Click += new System.EventHandler(this.labelEXT_Click);
            this.labelEXT.MouseEnter += new System.EventHandler(this.labelEXT_MouseEnter);
            this.labelEXT.MouseLeave += new System.EventHandler(this.labelEXT_MouseLeave);
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleForm.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelTitleForm.Location = new System.Drawing.Point(0, 0);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(1240, 40);
            this.labelTitleForm.TabIndex = 0;
            this.labelTitleForm.Text = "مدفوعات بالدولار/سندات الدفع بالدولار";
            this.labelTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUpperContainer
            // 
            this.panelUpperContainer.BackColor = System.Drawing.Color.White;
            this.panelUpperContainer.Controls.Add(this.tableLayoutPanelDateContain);
            this.panelUpperContainer.Controls.Add(this.tableLayoutPanelUpperControl);
            this.panelUpperContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpperContainer.Location = new System.Drawing.Point(5, 45);
            this.panelUpperContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelUpperContainer.Name = "panelUpperContainer";
            this.panelUpperContainer.Padding = new System.Windows.Forms.Padding(10);
            this.panelUpperContainer.Size = new System.Drawing.Size(1240, 75);
            this.panelUpperContainer.TabIndex = 2;
            // 
            // tableLayoutPanelDateContain
            // 
            this.tableLayoutPanelDateContain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelDateContain.ColumnCount = 1;
            this.tableLayoutPanelDateContain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDateContain.Controls.Add(this.dateTimePickerTransaction, 0, 0);
            this.tableLayoutPanelDateContain.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelDateContain.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanelDateContain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDateContain.Name = "tableLayoutPanelDateContain";
            this.tableLayoutPanelDateContain.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelDateContain.RowCount = 1;
            this.tableLayoutPanelDateContain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDateContain.Size = new System.Drawing.Size(200, 55);
            this.tableLayoutPanelDateContain.TabIndex = 1;
            // 
            // dateTimePickerTransaction
            // 
            this.dateTimePickerTransaction.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerTransaction.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimePickerTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTransaction.Location = new System.Drawing.Point(6, 6);
            this.dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            this.dateTimePickerTransaction.Size = new System.Drawing.Size(188, 24);
            this.dateTimePickerTransaction.TabIndex = 0;
            this.dateTimePickerTransaction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTimePickerTransaction_KeyPress);
            // 
            // tableLayoutPanelUpperControl
            // 
            this.tableLayoutPanelUpperControl.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelUpperControl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelUpperControl.ColumnCount = 5;
            this.tableLayoutPanelUpperControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelUpperControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelUpperControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelUpperControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelUpperControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelUpperControl.Controls.Add(this.buttonPrintallTransaction, 4, 0);
            this.tableLayoutPanelUpperControl.Controls.Add(this.buttonSaveTransaction, 3, 0);
            this.tableLayoutPanelUpperControl.Controls.Add(this.buttonDeleteallTransaction, 2, 0);
            this.tableLayoutPanelUpperControl.Controls.Add(this.buttonNewTransaction, 0, 0);
            this.tableLayoutPanelUpperControl.Controls.Add(this.buttonModifeTransaction, 1, 0);
            this.tableLayoutPanelUpperControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanelUpperControl.Location = new System.Drawing.Point(880, 10);
            this.tableLayoutPanelUpperControl.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelUpperControl.Name = "tableLayoutPanelUpperControl";
            this.tableLayoutPanelUpperControl.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelUpperControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanelUpperControl.RowCount = 1;
            this.tableLayoutPanelUpperControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUpperControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelUpperControl.Size = new System.Drawing.Size(350, 55);
            this.tableLayoutPanelUpperControl.TabIndex = 0;
            // 
            // buttonSaveTransaction
            // 
            this.buttonSaveTransaction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSaveTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSaveTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttonSaveTransaction.FlatAppearance.BorderSize = 2;
            this.buttonSaveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveTransaction.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonSaveTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonSaveTransaction.Location = new System.Drawing.Point(75, 6);
            this.buttonSaveTransaction.Name = "buttonSaveTransaction";
            this.buttonSaveTransaction.Size = new System.Drawing.Size(62, 43);
            this.buttonSaveTransaction.TabIndex = 4;
            this.buttonSaveTransaction.Text = "حفظ";
            this.buttonSaveTransaction.UseVisualStyleBackColor = false;
            this.buttonSaveTransaction.Click += new System.EventHandler(this.buttonSaveTransaction_Click);
            // 
            // buttonDeleteallTransaction
            // 
            this.buttonDeleteallTransaction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteallTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteallTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttonDeleteallTransaction.FlatAppearance.BorderSize = 2;
            this.buttonDeleteallTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteallTransaction.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonDeleteallTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonDeleteallTransaction.Location = new System.Drawing.Point(144, 6);
            this.buttonDeleteallTransaction.Name = "buttonDeleteallTransaction";
            this.buttonDeleteallTransaction.Size = new System.Drawing.Size(62, 43);
            this.buttonDeleteallTransaction.TabIndex = 4;
            this.buttonDeleteallTransaction.Text = "حذف";
            this.buttonDeleteallTransaction.UseVisualStyleBackColor = false;
            this.buttonDeleteallTransaction.Click += new System.EventHandler(this.buttonDeleteallTransaction_Click);
            // 
            // buttonNewTransaction
            // 
            this.buttonNewTransaction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNewTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNewTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttonNewTransaction.FlatAppearance.BorderSize = 2;
            this.buttonNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewTransaction.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonNewTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonNewTransaction.Location = new System.Drawing.Point(282, 6);
            this.buttonNewTransaction.Name = "buttonNewTransaction";
            this.buttonNewTransaction.Size = new System.Drawing.Size(62, 43);
            this.buttonNewTransaction.TabIndex = 1;
            this.buttonNewTransaction.Text = "جديد";
            this.buttonNewTransaction.UseVisualStyleBackColor = false;
            this.buttonNewTransaction.Click += new System.EventHandler(this.buttonNewTransaction_Click);
            // 
            // buttonModifeTransaction
            // 
            this.buttonModifeTransaction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonModifeTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonModifeTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttonModifeTransaction.FlatAppearance.BorderSize = 2;
            this.buttonModifeTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifeTransaction.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonModifeTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonModifeTransaction.Location = new System.Drawing.Point(213, 6);
            this.buttonModifeTransaction.Name = "buttonModifeTransaction";
            this.buttonModifeTransaction.Size = new System.Drawing.Size(62, 43);
            this.buttonModifeTransaction.TabIndex = 5;
            this.buttonModifeTransaction.Text = "تعديل";
            this.buttonModifeTransaction.UseVisualStyleBackColor = false;
            this.buttonModifeTransaction.Click += new System.EventHandler(this.buttonModifeTransaction_Click);
            // 
            // panelRightControl
            // 
            this.panelRightControl.BackColor = System.Drawing.Color.White;
            this.panelRightControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRightControl.Controls.Add(this.labelUserName);
            this.panelRightControl.Controls.Add(this.tableLayoutPanelRightContainer);
            this.panelRightControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightControl.Location = new System.Drawing.Point(1120, 120);
            this.panelRightControl.Margin = new System.Windows.Forms.Padding(0);
            this.panelRightControl.Name = "panelRightControl";
            this.panelRightControl.Padding = new System.Windows.Forms.Padding(5);
            this.panelRightControl.Size = new System.Drawing.Size(125, 595);
            this.panelRightControl.TabIndex = 3;
            // 
            // labelUserName
            // 
            this.labelUserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelUserName.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelUserName.Location = new System.Drawing.Point(5, 543);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(113, 45);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "محاسب";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelRightContainer
            // 
            this.tableLayoutPanelRightContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelRightContainer.ColumnCount = 1;
            this.tableLayoutPanelRightContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRightContainer.Controls.Add(this.buttonPrintTransaction, 0, 2);
            this.tableLayoutPanelRightContainer.Controls.Add(this.buttondeleteTransaction, 0, 1);
            this.tableLayoutPanelRightContainer.Controls.Add(this.buttonAddTransaction, 0, 0);
            this.tableLayoutPanelRightContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelRightContainer.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanelRightContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelRightContainer.Name = "tableLayoutPanelRightContainer";
            this.tableLayoutPanelRightContainer.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelRightContainer.RowCount = 3;
            this.tableLayoutPanelRightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelRightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRightContainer.Size = new System.Drawing.Size(113, 250);
            this.tableLayoutPanelRightContainer.TabIndex = 0;
            // 
            // buttondeleteTransaction
            // 
            this.buttondeleteTransaction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttondeleteTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttondeleteTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttondeleteTransaction.FlatAppearance.BorderSize = 2;
            this.buttondeleteTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondeleteTransaction.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttondeleteTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttondeleteTransaction.Location = new System.Drawing.Point(8, 89);
            this.buttondeleteTransaction.Margin = new System.Windows.Forms.Padding(5);
            this.buttondeleteTransaction.Name = "buttondeleteTransaction";
            this.buttondeleteTransaction.Size = new System.Drawing.Size(97, 70);
            this.buttondeleteTransaction.TabIndex = 6;
            this.buttondeleteTransaction.Text = "حذف حركة";
            this.buttondeleteTransaction.UseVisualStyleBackColor = false;
            this.buttondeleteTransaction.Click += new System.EventHandler(this.buttondeleteTransaction_Click);
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttonAddTransaction.FlatAppearance.BorderSize = 2;
            this.buttonAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTransaction.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonAddTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonAddTransaction.Location = new System.Drawing.Point(8, 8);
            this.buttonAddTransaction.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(97, 70);
            this.buttonAddTransaction.TabIndex = 3;
            this.buttonAddTransaction.Text = "أضافة حركة";
            this.buttonAddTransaction.UseVisualStyleBackColor = false;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridViewMoney, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelFooter, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 120);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1115, 595);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // dataGridViewMoney
            // 
            this.dataGridViewMoney.AllowUserToAddRows = false;
            this.dataGridViewMoney.AllowUserToDeleteRows = false;
            this.dataGridViewMoney.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewMoney.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Changa", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMoney.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewMoney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoney.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTransactionID,
            this.ColumnmoneyType,
            this.ColumnMoneyAmount,
            this.ColumnTansferPercentage,
            this.ColumnTotal,
            this.ColumnCutomerName,
            this.ColumnNotes});
            this.dataGridViewMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMoney.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMoney.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewMoney.MultiSelect = false;
            this.dataGridViewMoney.Name = "dataGridViewMoney";
            this.dataGridViewMoney.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewMoney.RowHeadersVisible = false;
            this.dataGridViewMoney.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMoney.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridViewMoney.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridViewMoney.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMoney.RowTemplate.Height = 40;
            this.dataGridViewMoney.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMoney.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewMoney.Size = new System.Drawing.Size(1109, 529);
            this.dataGridViewMoney.TabIndex = 3;
            this.dataGridViewMoney.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMoney_CellValueChanged);
            this.dataGridViewMoney.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewMoney_EditingControlShowing);
            this.dataGridViewMoney.SelectionChanged += new System.EventHandler(this.dataGridViewMoney_SelectionChanged);
            this.dataGridViewMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewMoney_KeyPress);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Transparent;
            this.panelFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFooter.Controls.Add(this.tableLayoutPanelCustomer);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFooter.Location = new System.Drawing.Point(3, 533);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(0);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(3);
            this.panelFooter.Size = new System.Drawing.Size(1109, 59);
            this.panelFooter.TabIndex = 4;
            // 
            // ColumnTransactionID
            // 
            this.ColumnTransactionID.DataPropertyName = "TransactionID";
            this.ColumnTransactionID.HeaderText = "رقم الحركة";
            this.ColumnTransactionID.Name = "ColumnTransactionID";
            this.ColumnTransactionID.ReadOnly = true;
            // 
            // ColumnmoneyType
            // 
            this.ColumnmoneyType.DataPropertyName = "PaidType";
            this.ColumnmoneyType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnmoneyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnmoneyType.HeaderText = "نوع العملة";
            this.ColumnmoneyType.Items.AddRange(new object[] {
            "دينار",
            "دولار"});
            this.ColumnmoneyType.Name = "ColumnmoneyType";
            // 
            // ColumnMoneyAmount
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.ColumnMoneyAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnMoneyAmount.HeaderText = "المبلغ";
            this.ColumnMoneyAmount.Name = "ColumnMoneyAmount";
            this.ColumnMoneyAmount.Width = 125;
            // 
            // ColumnTansferPercentage
            // 
            this.ColumnTansferPercentage.DataPropertyName = "TransferPercentage";
            dataGridViewCellStyle7.NullValue = null;
            this.ColumnTansferPercentage.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnTansferPercentage.HeaderText = "نسبة التحويل";
            this.ColumnTansferPercentage.Name = "ColumnTansferPercentage";
            this.ColumnTansferPercentage.Width = 120;
            // 
            // ColumnTotal
            // 
            dataGridViewCellStyle8.NullValue = null;
            this.ColumnTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnTotal.HeaderText = "مبلغ التعادل";
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.ReadOnly = true;
            this.ColumnTotal.Width = 125;
            // 
            // ColumnCutomerName
            // 
            this.ColumnCutomerName.DataPropertyName = "CutomerPaid";
            this.ColumnCutomerName.HeaderText = "الجهة";
            this.ColumnCutomerName.Name = "ColumnCutomerName";
            this.ColumnCutomerName.Width = 250;
            // 
            // ColumnNotes
            // 
            this.ColumnNotes.DataPropertyName = "TransactionDetails";
            this.ColumnNotes.HeaderText = "التفاصيل";
            this.ColumnNotes.Name = "ColumnNotes";
            this.ColumnNotes.Width = 350;
            // 
            // buttonPrintTransaction
            // 
            this.buttonPrintTransaction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrintTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrintTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttonPrintTransaction.FlatAppearance.BorderSize = 2;
            this.buttonPrintTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintTransaction.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonPrintTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonPrintTransaction.Location = new System.Drawing.Point(8, 170);
            this.buttonPrintTransaction.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPrintTransaction.Name = "buttonPrintTransaction";
            this.buttonPrintTransaction.Size = new System.Drawing.Size(97, 72);
            this.buttonPrintTransaction.TabIndex = 7;
            this.buttonPrintTransaction.Text = "طباعة حركة";
            this.buttonPrintTransaction.UseVisualStyleBackColor = false;
            // 
            // buttonPrintallTransaction
            // 
            this.buttonPrintallTransaction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrintallTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrintallTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.buttonPrintallTransaction.FlatAppearance.BorderSize = 2;
            this.buttonPrintallTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintallTransaction.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonPrintallTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonPrintallTransaction.Location = new System.Drawing.Point(6, 6);
            this.buttonPrintallTransaction.Name = "buttonPrintallTransaction";
            this.buttonPrintallTransaction.Size = new System.Drawing.Size(62, 43);
            this.buttonPrintallTransaction.TabIndex = 5;
            this.buttonPrintallTransaction.Text = "طباعة";
            this.buttonPrintallTransaction.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanelCustomer
            // 
            this.tableLayoutPanelCustomer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelCustomer.ColumnCount = 1;
            this.tableLayoutPanelCustomer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCustomer.Controls.Add(this.labelCutomerTotal, 0, 0);
            this.tableLayoutPanelCustomer.Controls.Add(this.textBoxCutomerTotal, 0, 1);
            this.tableLayoutPanelCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelCustomer.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelCustomer.Name = "tableLayoutPanelCustomer";
            this.tableLayoutPanelCustomer.RowCount = 2;
            this.tableLayoutPanelCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCustomer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCustomer.Size = new System.Drawing.Size(350, 49);
            this.tableLayoutPanelCustomer.TabIndex = 0;
            // 
            // labelCutomerTotal
            // 
            this.labelCutomerTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCutomerTotal.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelCutomerTotal.Location = new System.Drawing.Point(1, 1);
            this.labelCutomerTotal.Margin = new System.Windows.Forms.Padding(0);
            this.labelCutomerTotal.Name = "labelCutomerTotal";
            this.labelCutomerTotal.Size = new System.Drawing.Size(348, 23);
            this.labelCutomerTotal.TabIndex = 0;
            this.labelCutomerTotal.Text = "الرصيد الذي يمتلكه الزبون";
            this.labelCutomerTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCutomerTotal
            // 
            this.textBoxCutomerTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCutomerTotal.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxCutomerTotal.Location = new System.Drawing.Point(1, 25);
            this.textBoxCutomerTotal.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCutomerTotal.Multiline = true;
            this.textBoxCutomerTotal.Name = "textBoxCutomerTotal";
            this.textBoxCutomerTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCutomerTotal.Size = new System.Drawing.Size(348, 23);
            this.textBoxCutomerTotal.TabIndex = 1;
            this.textBoxCutomerTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PaidGetMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1250, 720);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panelRightControl);
            this.Controls.Add(this.panelUpperContainer);
            this.Controls.Add(this.panelFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaidGetMoney";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaidGetMoney";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelFormTitle.ResumeLayout(false);
            this.panelFormTitle.PerformLayout();
            this.panelUpperContainer.ResumeLayout(false);
            this.tableLayoutPanelDateContain.ResumeLayout(false);
            this.tableLayoutPanelUpperControl.ResumeLayout(false);
            this.panelRightControl.ResumeLayout(false);
            this.tableLayoutPanelRightContainer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoney)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.tableLayoutPanelCustomer.ResumeLayout(false);
            this.tableLayoutPanelCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormTitle;
        private System.Windows.Forms.Label labelEXT;
        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.Panel panelUpperContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDateContain;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpperControl;
        private System.Windows.Forms.Button buttonModifeTransaction;
        private System.Windows.Forms.Button buttonDeleteallTransaction;
        private System.Windows.Forms.Button buttonNewTransaction;
        private System.Windows.Forms.Panel panelRightControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightContainer;
        private System.Windows.Forms.Button buttondeleteTransaction;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonSaveTransaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewMoney;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTransactionID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnmoneyType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMoneyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTansferPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCutomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNotes;
        private System.Windows.Forms.Button buttonPrintallTransaction;
        private System.Windows.Forms.Button buttonPrintTransaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCustomer;
        private System.Windows.Forms.Label labelCutomerTotal;
        private System.Windows.Forms.TextBox textBoxCutomerTotal;
    }
}