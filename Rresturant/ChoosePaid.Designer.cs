namespace Rresturant
{
    partial class ChoosePaid
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
            this.panelFormTitle = new System.Windows.Forms.Panel();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.labelEXT = new System.Windows.Forms.Label();
            this.buttonUSMoney = new System.Windows.Forms.Button();
            this.buttonIQMoney = new System.Windows.Forms.Button();
            this.panelFormTitle.SuspendLayout();
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
            this.panelFormTitle.Size = new System.Drawing.Size(390, 40);
            this.panelFormTitle.TabIndex = 0;
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitleForm.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelTitleForm.Location = new System.Drawing.Point(0, 0);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(390, 40);
            this.labelTitleForm.TabIndex = 0;
            this.labelTitleForm.Text = "نوع المدفوعات/سندات االصرف";
            this.labelTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEXT
            // 
            this.labelEXT.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEXT.Font = new System.Drawing.Font("Changa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelEXT.ForeColor = System.Drawing.Color.White;
            this.labelEXT.Location = new System.Drawing.Point(340, 0);
            this.labelEXT.Name = "labelEXT";
            this.labelEXT.Size = new System.Drawing.Size(50, 40);
            this.labelEXT.TabIndex = 1;
            this.labelEXT.Text = "X";
            this.labelEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEXT.Click += new System.EventHandler(this.labelEXT_Click);
            this.labelEXT.MouseEnter += new System.EventHandler(this.labelEXT_MouseEnter);
            this.labelEXT.MouseLeave += new System.EventHandler(this.labelEXT_MouseLeave);
            // 
            // buttonUSMoney
            // 
            this.buttonUSMoney.BackColor = System.Drawing.Color.White;
            this.buttonUSMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonUSMoney.FlatAppearance.BorderSize = 2;
            this.buttonUSMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUSMoney.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonUSMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonUSMoney.Location = new System.Drawing.Point(50, 92);
            this.buttonUSMoney.Name = "buttonUSMoney";
            this.buttonUSMoney.Size = new System.Drawing.Size(100, 100);
            this.buttonUSMoney.TabIndex = 1;
            this.buttonUSMoney.Text = "الدولار";
            this.buttonUSMoney.UseVisualStyleBackColor = false;
            this.buttonUSMoney.Click += new System.EventHandler(this.buttonUSMoney_Click);
            // 
            // buttonIQMoney
            // 
            this.buttonIQMoney.BackColor = System.Drawing.Color.White;
            this.buttonIQMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonIQMoney.FlatAppearance.BorderSize = 2;
            this.buttonIQMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIQMoney.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonIQMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonIQMoney.Location = new System.Drawing.Point(250, 92);
            this.buttonIQMoney.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIQMoney.Name = "buttonIQMoney";
            this.buttonIQMoney.Size = new System.Drawing.Size(100, 100);
            this.buttonIQMoney.TabIndex = 2;
            this.buttonIQMoney.Text = "الدينار";
            this.buttonIQMoney.UseVisualStyleBackColor = false;
            this.buttonIQMoney.Click += new System.EventHandler(this.buttonIQMoney_Click);
            // 
            // ChoosePaid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.buttonIQMoney);
            this.Controls.Add(this.buttonUSMoney);
            this.Controls.Add(this.panelFormTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoosePaid";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChoosePaid";
            this.panelFormTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormTitle;
        private System.Windows.Forms.Label labelEXT;
        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.Button buttonUSMoney;
        private System.Windows.Forms.Button buttonIQMoney;
    }
}