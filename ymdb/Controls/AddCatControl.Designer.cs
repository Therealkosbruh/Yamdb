namespace ymdb.Controls
{
    partial class AddCatControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.catnameTb = new Guna.UI.WinForms.GunaTextBox();
            this.catslugTb = new Guna.UI.WinForms.GunaTextBox();
            this.AddCatBtn = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(141, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 33);
            this.label11.TabIndex = 54;
            this.label11.Text = "Добавьте Новую Категорию";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 55;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 33);
            this.label2.TabIndex = 56;
            this.label2.Text = "Eng";
            // 
            // catnameTb
            // 
            this.catnameTb.BackColor = System.Drawing.Color.Transparent;
            this.catnameTb.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.catnameTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.catnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catnameTb.FocusedBaseColor = System.Drawing.Color.White;
            this.catnameTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.catnameTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.catnameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catnameTb.ForeColor = System.Drawing.Color.White;
            this.catnameTb.Location = new System.Drawing.Point(190, 102);
            this.catnameTb.Name = "catnameTb";
            this.catnameTb.PasswordChar = '\0';
            this.catnameTb.Radius = 7;
            this.catnameTb.SelectedText = "";
            this.catnameTb.Size = new System.Drawing.Size(208, 30);
            this.catnameTb.TabIndex = 57;
            // 
            // catslugTb
            // 
            this.catslugTb.BackColor = System.Drawing.Color.Transparent;
            this.catslugTb.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.catslugTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.catslugTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.catslugTb.FocusedBaseColor = System.Drawing.Color.White;
            this.catslugTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.catslugTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.catslugTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.catslugTb.ForeColor = System.Drawing.Color.White;
            this.catslugTb.Location = new System.Drawing.Point(190, 161);
            this.catslugTb.Name = "catslugTb";
            this.catslugTb.PasswordChar = '\0';
            this.catslugTb.Radius = 7;
            this.catslugTb.SelectedText = "";
            this.catslugTb.Size = new System.Drawing.Size(208, 30);
            this.catslugTb.TabIndex = 58;
            // 
            // AddCatBtn
            // 
            this.AddCatBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddCatBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.AddCatBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.AddCatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCatBtn.FlatAppearance.BorderSize = 0;
            this.AddCatBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddCatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCatBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddCatBtn.Location = new System.Drawing.Point(190, 235);
            this.AddCatBtn.Name = "AddCatBtn";
            this.AddCatBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.AddCatBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.AddCatBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.AddCatBtn.Size = new System.Drawing.Size(158, 48);
            this.AddCatBtn.TabIndex = 59;
            this.AddCatBtn.Text = "Добавить";
            this.AddCatBtn.TextColor = System.Drawing.Color.Black;
            this.AddCatBtn.UseVisualStyleBackColor = false;
            this.AddCatBtn.Click += new System.EventHandler(this.AddCatBtn_Click);
            // 
            // AddCatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.AddCatBtn);
            this.Controls.Add(this.catslugTb);
            this.Controls.Add(this.catnameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "AddCatControl";
            this.Size = new System.Drawing.Size(550, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox catnameTb;
        private Guna.UI.WinForms.GunaTextBox catslugTb;
        private ePOSOne.btnProduct.Button_WOC AddCatBtn;
    }
}
