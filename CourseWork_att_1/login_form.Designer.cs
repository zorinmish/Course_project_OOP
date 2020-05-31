namespace CourseWork_att_1
{
    partial class login_form
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
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BackGr = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.password_field = new System.Windows.Forms.TextBox();
            this.login_field = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.header.SuspendLayout();
            this.BackGr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.header.Controls.Add(this.label1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(610, 91);
            this.header.TabIndex = 0;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.header_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // BackGr
            // 
            this.BackGr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BackGr.Controls.Add(this.clear);
            this.BackGr.Controls.Add(this.login);
            this.BackGr.Controls.Add(this.password_field);
            this.BackGr.Controls.Add(this.login_field);
            this.BackGr.Controls.Add(this.pictureBox2);
            this.BackGr.Controls.Add(this.pictureBox1);
            this.BackGr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGr.Location = new System.Drawing.Point(0, 91);
            this.BackGr.Name = "BackGr";
            this.BackGr.Size = new System.Drawing.Size(610, 429);
            this.BackGr.TabIndex = 1;
            // 
            // clear
            // 
            this.clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(359, 312);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(166, 56);
            this.clear.TabIndex = 5;
            this.clear.Text = "Очистить";
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            this.clear.MouseEnter += new System.EventHandler(this.clear_MouseEnter);
            this.clear.MouseLeave += new System.EventHandler(this.clear_MouseLeave);
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(97, 312);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(168, 56);
            this.login.TabIndex = 4;
            this.login.Text = "Войти";
            this.login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.MouseEnter += new System.EventHandler(this.login_MouseEnter);
            this.login.MouseLeave += new System.EventHandler(this.login_MouseLeave);
            // 
            // password_field
            // 
            this.password_field.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_field.Location = new System.Drawing.Point(129, 182);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(450, 72);
            this.password_field.TabIndex = 3;
            this.password_field.UseSystemPasswordChar = true;
            // 
            // login_field
            // 
            this.login_field.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_field.Location = new System.Drawing.Point(129, 57);
            this.login_field.Multiline = true;
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(450, 80);
            this.login_field.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CourseWork_att_1.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(42, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork_att_1.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(42, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 520);
            this.Controls.Add(this.BackGr);
            this.Controls.Add(this.header);
            this.Name = "login_form";
            this.Text = "Авторизация";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.BackGr.ResumeLayout(false);
            this.BackGr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel BackGr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.Label clear;
        private System.Windows.Forms.Label login;
    }
}