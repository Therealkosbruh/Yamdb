namespace ymdb
{
    partial class LolginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GuestLink = new System.Windows.Forms.LinkLabel();
            this.LoginTb = new Guna.UI.WinForms.GunaTextBox();
            this.PasswordTb = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginBtn = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ymdb.Properties.Resources.qweqwe;
            this.pictureBox1.Location = new System.Drawing.Point(133, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GuestLink
            // 
            this.GuestLink.AutoSize = true;
            this.GuestLink.Location = new System.Drawing.Point(130, 315);
            this.GuestLink.Name = "GuestLink";
            this.GuestLink.Size = new System.Drawing.Size(122, 13);
            this.GuestLink.TabIndex = 48;
            this.GuestLink.TabStop = true;
            this.GuestLink.Text = "Продолжить как гость";
            this.GuestLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GuestLink_LinkClicked);
            // 
            // LoginTb
            // 
            this.LoginTb.BackColor = System.Drawing.Color.Transparent;
            this.LoginTb.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LoginTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.LoginTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTb.FocusedBaseColor = System.Drawing.Color.White;
            this.LoginTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LoginTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginTb.ForeColor = System.Drawing.Color.White;
            this.LoginTb.Location = new System.Drawing.Point(85, 173);
            this.LoginTb.Name = "LoginTb";
            this.LoginTb.PasswordChar = '\0';
            this.LoginTb.Radius = 7;
            this.LoginTb.SelectedText = "";
            this.LoginTb.Size = new System.Drawing.Size(208, 30);
            this.LoginTb.TabIndex = 49;
            // 
            // PasswordTb
            // 
            this.PasswordTb.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTb.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PasswordTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.FocusedBaseColor = System.Drawing.Color.White;
            this.PasswordTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PasswordTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTb.ForeColor = System.Drawing.Color.White;
            this.PasswordTb.Location = new System.Drawing.Point(85, 244);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Radius = 7;
            this.PasswordTb.SelectedText = "";
            this.PasswordTb.Size = new System.Drawing.Size(208, 30);
            this.PasswordTb.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 33);
            this.label1.TabIndex = 51;
            this.label1.Text = "Вход";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.LoginBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBtn.Location = new System.Drawing.Point(111, 345);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.LoginBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.LoginBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.LoginBtn.Size = new System.Drawing.Size(158, 48);
            this.LoginBtn.TabIndex = 47;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.TextColor = System.Drawing.Color.Black;
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LolginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.LoginTb);
            this.Controls.Add(this.GuestLink);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LolginForm";
            this.Text = "Yamdb";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC LoginBtn;
        private System.Windows.Forms.LinkLabel GuestLink;
        private Guna.UI.WinForms.GunaTextBox LoginTb;
        private Guna.UI.WinForms.GunaTextBox PasswordTb;
        private System.Windows.Forms.Label label1;
    }
}

