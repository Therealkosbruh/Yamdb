namespace ymdb.Panels
{
    partial class AdminPanel
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepan = new System.Windows.Forms.Panel();
            this.GenreBtn = new System.Windows.Forms.Button();
            this.TitleBtn = new System.Windows.Forms.Button();
            this.CatBtn = new System.Windows.Forms.Button();
            this.addTitleControl1 = new ymdb.Controls.AddTitleControl();
            this.addGenreControl1 = new ymdb.Controls.AddGenreControl();
            this.addCatControl1 = new ymdb.Controls.AddCatControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.sidepan);
            this.panel1.Controls.Add(this.GenreBtn);
            this.panel1.Controls.Add(this.TitleBtn);
            this.panel1.Controls.Add(this.CatBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 450);
            this.panel1.TabIndex = 0;
            // 
            // sidepan
            // 
            this.sidepan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.sidepan.Location = new System.Drawing.Point(3, 98);
            this.sidepan.Name = "sidepan";
            this.sidepan.Size = new System.Drawing.Size(12, 34);
            this.sidepan.TabIndex = 1;
            // 
            // GenreBtn
            // 
            this.GenreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenreBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.GenreBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.GenreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.GenreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenreBtn.ForeColor = System.Drawing.Color.White;
            this.GenreBtn.Location = new System.Drawing.Point(19, 225);
            this.GenreBtn.Name = "GenreBtn";
            this.GenreBtn.Size = new System.Drawing.Size(201, 35);
            this.GenreBtn.TabIndex = 2;
            this.GenreBtn.Text = "Добавить Жанр";
            this.GenreBtn.UseVisualStyleBackColor = true;
            this.GenreBtn.Click += new System.EventHandler(this.GenreBtn_Click);
            // 
            // TitleBtn
            // 
            this.TitleBtn.BackColor = System.Drawing.Color.Transparent;
            this.TitleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TitleBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.TitleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.TitleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.TitleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBtn.ForeColor = System.Drawing.Color.White;
            this.TitleBtn.Location = new System.Drawing.Point(19, 97);
            this.TitleBtn.Name = "TitleBtn";
            this.TitleBtn.Size = new System.Drawing.Size(201, 35);
            this.TitleBtn.TabIndex = 3;
            this.TitleBtn.Text = "Добавить Произведение";
            this.TitleBtn.UseVisualStyleBackColor = false;
            this.TitleBtn.Click += new System.EventHandler(this.TitleBtn_Click);
            // 
            // CatBtn
            // 
            this.CatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.CatBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.CatBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.CatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CatBtn.ForeColor = System.Drawing.Color.White;
            this.CatBtn.Location = new System.Drawing.Point(19, 160);
            this.CatBtn.Name = "CatBtn";
            this.CatBtn.Size = new System.Drawing.Size(201, 35);
            this.CatBtn.TabIndex = 1;
            this.CatBtn.Text = "Добавить Категорию";
            this.CatBtn.UseVisualStyleBackColor = true;
            this.CatBtn.Click += new System.EventHandler(this.CatBtn_Click);
            // 
            // addTitleControl1
            // 
            this.addTitleControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.addTitleControl1.Location = new System.Drawing.Point(243, 99);
            this.addTitleControl1.Name = "addTitleControl1";
            this.addTitleControl1.Size = new System.Drawing.Size(550, 350);
            this.addTitleControl1.TabIndex = 3;
            // 
            // addGenreControl1
            // 
            this.addGenreControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.addGenreControl1.Location = new System.Drawing.Point(243, 100);
            this.addGenreControl1.Name = "addGenreControl1";
            this.addGenreControl1.Size = new System.Drawing.Size(550, 350);
            this.addGenreControl1.TabIndex = 2;
            // 
            // addCatControl1
            // 
            this.addCatControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.addCatControl1.Location = new System.Drawing.Point(243, 88);
            this.addCatControl1.Name = "addCatControl1";
            this.addCatControl1.Size = new System.Drawing.Size(550, 350);
            this.addCatControl1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ymdb.Properties.Resources.qweqwe;
            this.pictureBox1.Location = new System.Drawing.Point(467, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.button_WOC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_WOC1.Image = global::ymdb.Properties.Resources.free_icon_exit_39454521;
            this.button_WOC1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_WOC1.Location = new System.Drawing.Point(731, 12);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(197)))), ((int)(((byte)(24)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Black;
            this.button_WOC1.Size = new System.Drawing.Size(52, 42);
            this.button_WOC1.TabIndex = 82;
            this.button_WOC1.Text = "Out";
            this.button_WOC1.TextColor = System.Drawing.Color.Black;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addTitleControl1);
            this.Controls.Add(this.addGenreControl1);
            this.Controls.Add(this.addCatControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CatBtn;
        private System.Windows.Forms.Button TitleBtn;
        private System.Windows.Forms.Button GenreBtn;
        private System.Windows.Forms.Panel sidepan;
        private Controls.AddCatControl addCatControl1;
        private Controls.AddGenreControl addGenreControl1;
        private Controls.AddTitleControl addTitleControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}