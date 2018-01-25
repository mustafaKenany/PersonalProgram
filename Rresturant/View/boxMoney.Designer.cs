namespace Rresturant
{
    partial class boxMoney
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.labelEXT = new System.Windows.Forms.Label();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.comboBoxUserName = new System.Windows.Forms.ComboBox();
            this.buttonUSMoneyOnly = new System.Windows.Forms.Button();
            this.buttonIDMoneyOnly = new System.Windows.Forms.Button();
            this.button_AllMoney = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMoneyForUser = new System.Windows.Forms.RadioButton();
            this.radioButtonAllMoney = new System.Windows.Forms.RadioButton();
            this.panelForm.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.panelForm.Controls.Add(this.labelEXT);
            this.panelForm.Controls.Add(this.labelTitleForm);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForm.Location = new System.Drawing.Point(5, 5);
            this.panelForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(640, 40);
            this.panelForm.TabIndex = 0;
            // 
            // labelEXT
            // 
            this.labelEXT.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelEXT.Font = new System.Drawing.Font("Changa", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelEXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.labelEXT.Location = new System.Drawing.Point(590, 0);
            this.labelEXT.Margin = new System.Windows.Forms.Padding(0);
            this.labelEXT.Name = "labelEXT";
            this.labelEXT.Size = new System.Drawing.Size(50, 40);
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
            this.labelTitleForm.Size = new System.Drawing.Size(640, 40);
            this.labelTitleForm.TabIndex = 0;
            this.labelTitleForm.Text = "الصندوق";
            this.labelTitleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Snow;
            this.panelContainer.Controls.Add(this.comboBoxUserName);
            this.panelContainer.Controls.Add(this.buttonUSMoneyOnly);
            this.panelContainer.Controls.Add(this.buttonIDMoneyOnly);
            this.panelContainer.Controls.Add(this.button_AllMoney);
            this.panelContainer.Controls.Add(this.dateTimePickerDate);
            this.panelContainer.Controls.Add(this.radioButtonMoneyForUser);
            this.panelContainer.Controls.Add(this.radioButtonAllMoney);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(5, 45);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panelContainer.Size = new System.Drawing.Size(640, 450);
            this.panelContainer.TabIndex = 1;
            // 
            // comboBoxUserName
            // 
            this.comboBoxUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUserName.DropDownWidth = 150;
            this.comboBoxUserName.Enabled = false;
            this.comboBoxUserName.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.comboBoxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.comboBoxUserName.FormattingEnabled = true;
            this.comboBoxUserName.Location = new System.Drawing.Point(145, 56);
            this.comboBoxUserName.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxUserName.Name = "comboBoxUserName";
            this.comboBoxUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxUserName.Size = new System.Drawing.Size(250, 34);
            this.comboBoxUserName.TabIndex = 6;
            // 
            // buttonUSMoneyOnly
            // 
            this.buttonUSMoneyOnly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUSMoneyOnly.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUSMoneyOnly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUSMoneyOnly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUSMoneyOnly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonUSMoneyOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUSMoneyOnly.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUSMoneyOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonUSMoneyOnly.Image = global::Rresturant.Properties.Resources.payment;
            this.buttonUSMoneyOnly.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonUSMoneyOnly.Location = new System.Drawing.Point(55, 157);
            this.buttonUSMoneyOnly.Margin = new System.Windows.Forms.Padding(10);
            this.buttonUSMoneyOnly.Name = "buttonUSMoneyOnly";
            this.buttonUSMoneyOnly.Size = new System.Drawing.Size(160, 160);
            this.buttonUSMoneyOnly.TabIndex = 5;
            this.buttonUSMoneyOnly.Text = "طباعة الدولار فقط";
            this.buttonUSMoneyOnly.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonUSMoneyOnly.UseVisualStyleBackColor = false;
            // 
            // buttonIDMoneyOnly
            // 
            this.buttonIDMoneyOnly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIDMoneyOnly.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonIDMoneyOnly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonIDMoneyOnly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIDMoneyOnly.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonIDMoneyOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIDMoneyOnly.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIDMoneyOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.buttonIDMoneyOnly.Image = global::Rresturant.Properties.Resources.money;
            this.buttonIDMoneyOnly.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonIDMoneyOnly.Location = new System.Drawing.Point(235, 157);
            this.buttonIDMoneyOnly.Margin = new System.Windows.Forms.Padding(10);
            this.buttonIDMoneyOnly.Name = "buttonIDMoneyOnly";
            this.buttonIDMoneyOnly.Size = new System.Drawing.Size(160, 160);
            this.buttonIDMoneyOnly.TabIndex = 4;
            this.buttonIDMoneyOnly.Text = "طباعة الدينار فقط";
            this.buttonIDMoneyOnly.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonIDMoneyOnly.UseVisualStyleBackColor = false;
            // 
            // button_AllMoney
            // 
            this.button_AllMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AllMoney.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_AllMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_AllMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AllMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button_AllMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AllMoney.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AllMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button_AllMoney.Image = global::Rresturant.Properties.Resources.debt1;
            this.button_AllMoney.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_AllMoney.Location = new System.Drawing.Point(415, 157);
            this.button_AllMoney.Margin = new System.Windows.Forms.Padding(10);
            this.button_AllMoney.Name = "button_AllMoney";
            this.button_AllMoney.Size = new System.Drawing.Size(160, 160);
            this.button_AllMoney.TabIndex = 3;
            this.button_AllMoney.Text = "طباعة الكل";
            this.button_AllMoney.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_AllMoney.UseVisualStyleBackColor = false;
            this.button_AllMoney.Click += new System.EventHandler(this.button_AllMoney_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarFont = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(5, 5);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 33);
            this.dateTimePickerDate.TabIndex = 2;
            // 
            // radioButtonMoneyForUser
            // 
            this.radioButtonMoneyForUser.AutoSize = true;
            this.radioButtonMoneyForUser.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioButtonMoneyForUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.radioButtonMoneyForUser.Location = new System.Drawing.Point(412, 56);
            this.radioButtonMoneyForUser.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonMoneyForUser.Name = "radioButtonMoneyForUser";
            this.radioButtonMoneyForUser.Size = new System.Drawing.Size(221, 30);
            this.radioButtonMoneyForUser.TabIndex = 1;
            this.radioButtonMoneyForUser.TabStop = true;
            this.radioButtonMoneyForUser.Text = "طباعة الصندوق لمحاسب معين";
            this.radioButtonMoneyForUser.UseVisualStyleBackColor = true;
            this.radioButtonMoneyForUser.CheckedChanged += new System.EventHandler(this.radioButtonMoneyForUser_CheckedChanged);
            // 
            // radioButtonAllMoney
            // 
            this.radioButtonAllMoney.AutoSize = true;
            this.radioButtonAllMoney.Font = new System.Drawing.Font("Changa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioButtonAllMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.radioButtonAllMoney.Location = new System.Drawing.Point(441, 8);
            this.radioButtonAllMoney.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonAllMoney.Name = "radioButtonAllMoney";
            this.radioButtonAllMoney.Size = new System.Drawing.Size(192, 30);
            this.radioButtonAllMoney.TabIndex = 0;
            this.radioButtonAllMoney.TabStop = true;
            this.radioButtonAllMoney.Text = "طباعة الصندوق بشكل عام";
            this.radioButtonAllMoney.UseVisualStyleBackColor = true;
            // 
            // boxMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.Name = "boxMoney";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "boxMoney";
            this.panelForm.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label labelTitleForm;
        private System.Windows.Forms.Label labelEXT;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.RadioButton radioButtonMoneyForUser;
        private System.Windows.Forms.RadioButton radioButtonAllMoney;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        public System.Windows.Forms.Button buttonUSMoneyOnly;
        public System.Windows.Forms.Button buttonIDMoneyOnly;
        public System.Windows.Forms.Button button_AllMoney;
        private System.Windows.Forms.ComboBox comboBoxUserName;
    }
}