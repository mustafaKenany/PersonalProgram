﻿namespace Rresturant
{
    partial class itemsReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemsReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilteritemsGrid = new System.Windows.Forms.TextBox();
            this.button_showAllitems = new System.Windows.Forms.Button();
            this.buttonPrintitemsGrid = new System.Windows.Forms.Button();
            this.dataGridView_displayitems = new System.Windows.Forms.DataGridView();
            this.ColumnItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItemLastPriceSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnShowAllSaleInvoices = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnAllBuyInvoices = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnSavedSaleInvoices = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnSavedPurchaseInvoice = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayitems)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(1115, 40);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1071, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "المواد";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(1072, 1);
            this.Exit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(42, 38);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Changa Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(5, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(1115, 70);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "ادخل كلمة للبحث";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxFilteritemsGrid
            // 
            this.textBoxFilteritemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilteritemsGrid.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.textBoxFilteritemsGrid.Location = new System.Drawing.Point(2, 28);
            this.textBoxFilteritemsGrid.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxFilteritemsGrid.Multiline = true;
            this.textBoxFilteritemsGrid.Name = "textBoxFilteritemsGrid";
            this.textBoxFilteritemsGrid.Size = new System.Drawing.Size(346, 36);
            this.textBoxFilteritemsGrid.TabIndex = 4;
            this.textBoxFilteritemsGrid.Text = "هنا";
            this.textBoxFilteritemsGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFilteritemsGrid.TextChanged += new System.EventHandler(this.textBoxFilteritemsGrid_TextChanged);
            // 
            // button_showAllitems
            // 
            this.button_showAllitems.AutoSize = true;
            this.button_showAllitems.BackColor = System.Drawing.Color.White;
            this.button_showAllitems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_showAllitems.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_showAllitems.FlatAppearance.BorderSize = 2;
            this.button_showAllitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_showAllitems.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_showAllitems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button_showAllitems.Location = new System.Drawing.Point(103, 4);
            this.button_showAllitems.Name = "button_showAllitems";
            this.button_showAllitems.Size = new System.Drawing.Size(93, 58);
            this.button_showAllitems.TabIndex = 3;
            this.button_showAllitems.Text = "عرض المواد";
            this.button_showAllitems.UseVisualStyleBackColor = false;
            this.button_showAllitems.Click += new System.EventHandler(this.button_showAllitems_Click);
            // 
            // buttonPrintitemsGrid
            // 
            this.buttonPrintitemsGrid.AutoSize = true;
            this.buttonPrintitemsGrid.BackColor = System.Drawing.Color.White;
            this.buttonPrintitemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrintitemsGrid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonPrintitemsGrid.FlatAppearance.BorderSize = 2;
            this.buttonPrintitemsGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrintitemsGrid.Font = new System.Drawing.Font("Changa Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonPrintitemsGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonPrintitemsGrid.Location = new System.Drawing.Point(4, 4);
            this.buttonPrintitemsGrid.Name = "buttonPrintitemsGrid";
            this.buttonPrintitemsGrid.Size = new System.Drawing.Size(92, 58);
            this.buttonPrintitemsGrid.TabIndex = 2;
            this.buttonPrintitemsGrid.Text = "طباعة";
            this.buttonPrintitemsGrid.UseVisualStyleBackColor = false;
            this.buttonPrintitemsGrid.Click += new System.EventHandler(this.buttonPrintitemsGrid_Click);
            // 
            // dataGridView_displayitems
            // 
            this.dataGridView_displayitems.AllowUserToAddRows = false;
            this.dataGridView_displayitems.AllowUserToDeleteRows = false;
            this.dataGridView_displayitems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_displayitems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_displayitems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_displayitems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView_displayitems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayitems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_displayitems.ColumnHeadersHeight = 40;
            this.dataGridView_displayitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnItemID,
            this.ColumnItemName,
            this.ColumnItemCategory,
            this.ColumnItemBarCode,
            this.ColumnItemQuantity,
            this.ColumnItemBuyPrice,
            this.ColumnItemLastPriceSale,
            this.ColumnShowAllSaleInvoices,
            this.ColumnAllBuyInvoices,
            this.ColumnSavedSaleInvoices,
            this.ColumnSavedPurchaseInvoice});
            this.dataGridView_displayitems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_displayitems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.dataGridView_displayitems.Location = new System.Drawing.Point(5, 115);
            this.dataGridView_displayitems.MultiSelect = false;
            this.dataGridView_displayitems.Name = "dataGridView_displayitems";
            this.dataGridView_displayitems.ReadOnly = true;
            this.dataGridView_displayitems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_displayitems.RowHeadersVisible = false;
            this.dataGridView_displayitems.RowHeadersWidth = 45;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_displayitems.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_displayitems.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_displayitems.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Changa", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dataGridView_displayitems.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_displayitems.RowTemplate.Height = 40;
            this.dataGridView_displayitems.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_displayitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_displayitems.Size = new System.Drawing.Size(1115, 580);
            this.dataGridView_displayitems.TabIndex = 9;
            this.dataGridView_displayitems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_displayitems_CellContentClick);
            // 
            // ColumnItemID
            // 
            this.ColumnItemID.DataPropertyName = "ItemID";
            this.ColumnItemID.HeaderText = "رمز المادة";
            this.ColumnItemID.Name = "ColumnItemID";
            this.ColumnItemID.ReadOnly = true;
            this.ColumnItemID.Width = 75;
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.DataPropertyName = "ItemName";
            this.ColumnItemName.HeaderText = "الـــــمادة";
            this.ColumnItemName.Name = "ColumnItemName";
            this.ColumnItemName.ReadOnly = true;
            this.ColumnItemName.Width = 200;
            // 
            // ColumnItemCategory
            // 
            this.ColumnItemCategory.DataPropertyName = "itemCategory";
            this.ColumnItemCategory.HeaderText = "الصنف";
            this.ColumnItemCategory.Name = "ColumnItemCategory";
            this.ColumnItemCategory.ReadOnly = true;
            this.ColumnItemCategory.Width = 150;
            // 
            // ColumnItemBarCode
            // 
            this.ColumnItemBarCode.DataPropertyName = "ItemBarCode";
            this.ColumnItemBarCode.HeaderText = "الباركود";
            this.ColumnItemBarCode.Name = "ColumnItemBarCode";
            this.ColumnItemBarCode.ReadOnly = true;
            this.ColumnItemBarCode.Width = 90;
            // 
            // ColumnItemQuantity
            // 
            this.ColumnItemQuantity.DataPropertyName = "StockQuantity";
            this.ColumnItemQuantity.HeaderText = "الكمية ";
            this.ColumnItemQuantity.Name = "ColumnItemQuantity";
            this.ColumnItemQuantity.ReadOnly = true;
            this.ColumnItemQuantity.Width = 90;
            // 
            // ColumnItemBuyPrice
            // 
            this.ColumnItemBuyPrice.DataPropertyName = "price_for_buy";
            this.ColumnItemBuyPrice.HeaderText = "سعر البيع";
            this.ColumnItemBuyPrice.Name = "ColumnItemBuyPrice";
            this.ColumnItemBuyPrice.ReadOnly = true;
            this.ColumnItemBuyPrice.Width = 90;
            // 
            // ColumnItemLastPriceSale
            // 
            this.ColumnItemLastPriceSale.DataPropertyName = "LastPrice";
            this.ColumnItemLastPriceSale.HeaderText = "اخر شراء";
            this.ColumnItemLastPriceSale.Name = "ColumnItemLastPriceSale";
            this.ColumnItemLastPriceSale.ReadOnly = true;
            this.ColumnItemLastPriceSale.Width = 90;
            // 
            // ColumnShowAllSaleInvoices
            // 
            this.ColumnShowAllSaleInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnShowAllSaleInvoices.HeaderText = "فواتير الشراء";
            this.ColumnShowAllSaleInvoices.Name = "ColumnShowAllSaleInvoices";
            this.ColumnShowAllSaleInvoices.ReadOnly = true;
            this.ColumnShowAllSaleInvoices.Text = "تفاصيل";
            this.ColumnShowAllSaleInvoices.UseColumnTextForButtonValue = true;
            // 
            // ColumnAllBuyInvoices
            // 
            this.ColumnAllBuyInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnAllBuyInvoices.HeaderText = "فواتير البيع";
            this.ColumnAllBuyInvoices.Name = "ColumnAllBuyInvoices";
            this.ColumnAllBuyInvoices.ReadOnly = true;
            this.ColumnAllBuyInvoices.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAllBuyInvoices.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnAllBuyInvoices.Text = "تفاصيل";
            this.ColumnAllBuyInvoices.UseColumnTextForButtonValue = true;
            // 
            // ColumnSavedSaleInvoices
            // 
            this.ColumnSavedSaleInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnSavedSaleInvoices.HeaderText = "البيع المحفوظة";
            this.ColumnSavedSaleInvoices.Name = "ColumnSavedSaleInvoices";
            this.ColumnSavedSaleInvoices.ReadOnly = true;
            this.ColumnSavedSaleInvoices.Text = "تفاصيل";
            this.ColumnSavedSaleInvoices.UseColumnTextForButtonValue = true;
            this.ColumnSavedSaleInvoices.Width = 125;
            // 
            // ColumnSavedPurchaseInvoice
            // 
            this.ColumnSavedPurchaseInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnSavedPurchaseInvoice.HeaderText = "الشراء المحفوظة";
            this.ColumnSavedPurchaseInvoice.Name = "ColumnSavedPurchaseInvoice";
            this.ColumnSavedPurchaseInvoice.ReadOnly = true;
            this.ColumnSavedPurchaseInvoice.Text = "تفاصيل";
            this.ColumnSavedPurchaseInvoice.UseColumnTextForButtonValue = true;
            this.ColumnSavedPurchaseInvoice.Width = 125;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button_showAllitems, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrintitemsGrid, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(913, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 66);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxFilteritemsGrid, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(350, 66);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // itemsReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1125, 700);
            this.Controls.Add(this.dataGridView_displayitems);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 15);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "itemsReportForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "itemsReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_displayitems)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPrintitemsGrid;
        private System.Windows.Forms.Button button_showAllitems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilteritemsGrid;
        private System.Windows.Forms.DataGridView dataGridView_displayitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnItemLastPriceSale;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnShowAllSaleInvoices;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAllBuyInvoices;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSavedSaleInvoices;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSavedPurchaseInvoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}