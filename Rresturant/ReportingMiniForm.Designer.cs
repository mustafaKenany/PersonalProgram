namespace Rresturant
{
    partial class ReportingMiniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingMiniForm));
            this.panelTitleForm = new System.Windows.Forms.Panel();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.buttonCoustomers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSaleInvoices = new System.Windows.Forms.Button();
            this.buttonAllitemsReport = new System.Windows.Forms.Button();
            this.buttonBuyInvoices = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panelTitleForm.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleForm
            // 
            this.panelTitleForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panelTitleForm.Controls.Add(this.labelTitleForm);
            this.panelTitleForm.Controls.Add(this.Exit);
            this.panelTitleForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleForm.Location = new System.Drawing.Point(3, 3);
            this.panelTitleForm.Name = "panelTitleForm";
            this.panelTitleForm.Size = new System.Drawing.Size(594, 40);
            this.panelTitleForm.TabIndex = 1;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleForm.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.labelTitleForm.Location = new System.Drawing.Point(0, 0);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(551, 40);
            this.labelTitleForm.TabIndex = 4;
            this.labelTitleForm.Text = "التقارير";
            this.labelTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCoustomers
            // 
            this.buttonCoustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCoustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCoustomers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonCoustomers.FlatAppearance.BorderSize = 2;
            this.buttonCoustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCoustomers.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCoustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonCoustomers.Image = global::Rresturant.Properties.Resources.users2;
            this.buttonCoustomers.Location = new System.Drawing.Point(69, 200);
            this.buttonCoustomers.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCoustomers.Name = "buttonCoustomers";
            this.buttonCoustomers.Size = new System.Drawing.Size(160, 160);
            this.buttonCoustomers.TabIndex = 18;
            this.buttonCoustomers.Text = "الزبائن";
            this.buttonCoustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCoustomers.UseVisualStyleBackColor = true;
            this.buttonCoustomers.Click += new System.EventHandler(this.buttonCoustomers_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonSaleInvoices);
            this.panel2.Controls.Add(this.buttonCoustomers);
            this.panel2.Controls.Add(this.buttonAllitemsReport);
            this.panel2.Controls.Add(this.buttonBuyInvoices);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 454);
            this.panel2.TabIndex = 19;
            // 
            // buttonSaleInvoices
            // 
            this.buttonSaleInvoices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaleInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaleInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonSaleInvoices.FlatAppearance.BorderSize = 2;
            this.buttonSaleInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaleInvoices.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonSaleInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonSaleInvoices.Image = global::Rresturant.Properties.Resources.purchasesIcon;
            this.buttonSaleInvoices.Location = new System.Drawing.Point(368, 14);
            this.buttonSaleInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSaleInvoices.Name = "buttonSaleInvoices";
            this.buttonSaleInvoices.Size = new System.Drawing.Size(160, 160);
            this.buttonSaleInvoices.TabIndex = 16;
            this.buttonSaleInvoices.Text = "فواتير الشراء";
            this.buttonSaleInvoices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSaleInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSaleInvoices.UseVisualStyleBackColor = true;
            this.buttonSaleInvoices.Click += new System.EventHandler(this.buttonSaleInvoices_Click);
            // 
            // buttonAllitemsReport
            // 
            this.buttonAllitemsReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAllitemsReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAllitemsReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonAllitemsReport.FlatAppearance.BorderSize = 2;
            this.buttonAllitemsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllitemsReport.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonAllitemsReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonAllitemsReport.Image = global::Rresturant.Properties.Resources.supermarket;
            this.buttonAllitemsReport.Location = new System.Drawing.Point(368, 200);
            this.buttonAllitemsReport.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAllitemsReport.Name = "buttonAllitemsReport";
            this.buttonAllitemsReport.Size = new System.Drawing.Size(160, 160);
            this.buttonAllitemsReport.TabIndex = 15;
            this.buttonAllitemsReport.Text = "المواد";
            this.buttonAllitemsReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAllitemsReport.UseVisualStyleBackColor = true;
            this.buttonAllitemsReport.Click += new System.EventHandler(this.buttonAllitemsReport_Click);
            // 
            // buttonBuyInvoices
            // 
            this.buttonBuyInvoices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuyInvoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBuyInvoices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonBuyInvoices.FlatAppearance.BorderSize = 2;
            this.buttonBuyInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuyInvoices.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonBuyInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.buttonBuyInvoices.Image = global::Rresturant.Properties.Resources.invoiceIcon;
            this.buttonBuyInvoices.Location = new System.Drawing.Point(69, 14);
            this.buttonBuyInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBuyInvoices.Name = "buttonBuyInvoices";
            this.buttonBuyInvoices.Size = new System.Drawing.Size(160, 160);
            this.buttonBuyInvoices.TabIndex = 17;
            this.buttonBuyInvoices.Text = "فواتير البيع";
            this.buttonBuyInvoices.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBuyInvoices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBuyInvoices.UseVisualStyleBackColor = true;
            this.buttonBuyInvoices.Click += new System.EventHandler(this.buttonBuyInvoices_Click);
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(551, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(43, 40);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ReportingMiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTitleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportingMiniForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportingMiniForm";
            this.panelTitleForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitleForm;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.Button buttonAllitemsReport;
        private System.Windows.Forms.Button buttonSaleInvoices;
        private System.Windows.Forms.Button buttonBuyInvoices;
        private System.Windows.Forms.Button buttonCoustomers;
        private System.Windows.Forms.Panel panel2;
    }
}