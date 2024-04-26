namespace ymdb.Controls
{
    partial class AddTitleControl
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
            this.AddTitleBtn = new ePOSOne.btnProduct.Button_WOC();
            this.nameTb = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.YearTb = new Guna.UI.WinForms.GunaTextBox();
            this.CategoryIdLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CatCB = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genreCB = new Guna.UI.WinForms.GunaComboBox();
            this.GenreLbl = new System.Windows.Forms.Label();
            this.titleidLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddTitleBtn
            // 
            this.AddTitleBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddTitleBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.AddTitleBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.AddTitleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTitleBtn.FlatAppearance.BorderSize = 0;
            this.AddTitleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddTitleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddTitleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTitleBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTitleBtn.Location = new System.Drawing.Point(188, 284);
            this.AddTitleBtn.Name = "AddTitleBtn";
            this.AddTitleBtn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.AddTitleBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.AddTitleBtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.AddTitleBtn.Size = new System.Drawing.Size(158, 48);
            this.AddTitleBtn.TabIndex = 65;
            this.AddTitleBtn.Text = "Добавить";
            this.AddTitleBtn.TextColor = System.Drawing.Color.Black;
            this.AddTitleBtn.UseVisualStyleBackColor = false;
            this.AddTitleBtn.Click += new System.EventHandler(this.AddTitleBtn_Click);
            // 
            // nameTb
            // 
            this.nameTb.BackColor = System.Drawing.Color.Transparent;
            this.nameTb.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.nameTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.nameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTb.FocusedBaseColor = System.Drawing.Color.White;
            this.nameTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.nameTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTb.ForeColor = System.Drawing.Color.White;
            this.nameTb.Location = new System.Drawing.Point(182, 73);
            this.nameTb.Name = "nameTb";
            this.nameTb.PasswordChar = '\0';
            this.nameTb.Radius = 7;
            this.nameTb.SelectedText = "";
            this.nameTb.Size = new System.Drawing.Size(208, 30);
            this.nameTb.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 33);
            this.label2.TabIndex = 62;
            this.label2.Text = "Год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 61;
            this.label1.Text = "Название";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(131, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(287, 33);
            this.label11.TabIndex = 60;
            this.label11.Text = "Добавьте Новое Произведение";
            // 
            // YearTb
            // 
            this.YearTb.BackColor = System.Drawing.Color.Transparent;
            this.YearTb.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.YearTb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.YearTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.YearTb.FocusedBaseColor = System.Drawing.Color.White;
            this.YearTb.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.YearTb.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.YearTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.YearTb.ForeColor = System.Drawing.Color.White;
            this.YearTb.Location = new System.Drawing.Point(182, 131);
            this.YearTb.Name = "YearTb";
            this.YearTb.PasswordChar = '\0';
            this.YearTb.Radius = 7;
            this.YearTb.SelectedText = "";
            this.YearTb.Size = new System.Drawing.Size(208, 30);
            this.YearTb.TabIndex = 64;
            // 
            // CategoryIdLbl
            // 
            this.CategoryIdLbl.AutoSize = true;
            this.CategoryIdLbl.Location = new System.Drawing.Point(367, 190);
            this.CategoryIdLbl.Name = "CategoryIdLbl";
            this.CategoryIdLbl.Size = new System.Drawing.Size(35, 13);
            this.CategoryIdLbl.TabIndex = 68;
            this.CategoryIdLbl.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 67;
            this.label3.Text = "Выберите Категорию";
            // 
            // CatCB
            // 
            this.CatCB.BackColor = System.Drawing.Color.Transparent;
            this.CatCB.BaseColor = System.Drawing.Color.White;
            this.CatCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.CatCB.BorderSize = 3;
            this.CatCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.CatCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CatCB.ForeColor = System.Drawing.Color.Black;
            this.CatCB.FormattingEnabled = true;
            this.CatCB.Items.AddRange(new object[] {
            "Фильм",
            "Книга",
            "Музыка"});
            this.CatCB.Location = new System.Drawing.Point(188, 184);
            this.CatCB.Name = "CatCB";
            this.CatCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.CatCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CatCB.Radius = 6;
            this.CatCB.Size = new System.Drawing.Size(148, 26);
            this.CatCB.TabIndex = 66;
            this.CatCB.SelectedIndexChanged += new System.EventHandler(this.CatCB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 70;
            this.label4.Text = "Выберите Жанр";
            // 
            // genreCB
            // 
            this.genreCB.BackColor = System.Drawing.Color.Transparent;
            this.genreCB.BaseColor = System.Drawing.Color.White;
            this.genreCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.genreCB.BorderSize = 3;
            this.genreCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genreCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.genreCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genreCB.ForeColor = System.Drawing.Color.Black;
            this.genreCB.FormattingEnabled = true;
            this.genreCB.Location = new System.Drawing.Point(188, 234);
            this.genreCB.Name = "genreCB";
            this.genreCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.genreCB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.genreCB.Radius = 6;
            this.genreCB.Size = new System.Drawing.Size(148, 26);
            this.genreCB.TabIndex = 69;
            this.genreCB.SelectedIndexChanged += new System.EventHandler(this.genreCB_SelectedIndexChanged);
            // 
            // GenreLbl
            // 
            this.GenreLbl.AutoSize = true;
            this.GenreLbl.Location = new System.Drawing.Point(367, 241);
            this.GenreLbl.Name = "GenreLbl";
            this.GenreLbl.Size = new System.Drawing.Size(35, 13);
            this.GenreLbl.TabIndex = 71;
            this.GenreLbl.Text = "label3";
            // 
            // titleidLbl
            // 
            this.titleidLbl.AutoSize = true;
            this.titleidLbl.Location = new System.Drawing.Point(26, 16);
            this.titleidLbl.Name = "titleidLbl";
            this.titleidLbl.Size = new System.Drawing.Size(0, 13);
            this.titleidLbl.TabIndex = 72;
            // 
            // AddTitleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.titleidLbl);
            this.Controls.Add(this.GenreLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.genreCB);
            this.Controls.Add(this.CategoryIdLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CatCB);
            this.Controls.Add(this.AddTitleBtn);
            this.Controls.Add(this.YearTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "AddTitleControl";
            this.Size = new System.Drawing.Size(550, 350);
            this.Load += new System.EventHandler(this.AddTitleControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC AddTitleBtn;
        private Guna.UI.WinForms.GunaTextBox nameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox YearTb;
        private System.Windows.Forms.Label CategoryIdLbl;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox CatCB;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox genreCB;
        private System.Windows.Forms.Label GenreLbl;
        private System.Windows.Forms.Label titleidLbl;
    }
}
