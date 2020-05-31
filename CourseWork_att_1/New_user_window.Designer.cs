namespace CourseWork_att_1
{
    partial class New_user_window
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
            this.BackGr = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.doublicate = new System.Windows.Forms.TextBox();
            this.password_field = new System.Windows.Forms.TextBox();
            this.login_field = new System.Windows.Forms.TextBox();
            this.new_user_button = new System.Windows.Forms.Label();
            this.cansel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.Name_of_window = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackGr.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGr
            // 
            this.BackGr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BackGr.Controls.Add(this.label4);
            this.BackGr.Controls.Add(this.status);
            this.BackGr.Controls.Add(this.label3);
            this.BackGr.Controls.Add(this.label2);
            this.BackGr.Controls.Add(this.label1);
            this.BackGr.Controls.Add(this.doublicate);
            this.BackGr.Controls.Add(this.password_field);
            this.BackGr.Controls.Add(this.login_field);
            this.BackGr.Controls.Add(this.new_user_button);
            this.BackGr.Controls.Add(this.cansel);
            this.BackGr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGr.Location = new System.Drawing.Point(0, 121);
            this.BackGr.Name = "BackGr";
            this.BackGr.Size = new System.Drawing.Size(716, 565);
            this.BackGr.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин";
            // 
            // doublicate
            // 
            this.doublicate.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doublicate.Location = new System.Drawing.Point(254, 352);
            this.doublicate.Name = "doublicate";
            this.doublicate.PasswordChar = '*';
            this.doublicate.Size = new System.Drawing.Size(450, 63);
            this.doublicate.TabIndex = 13;
            this.doublicate.UseSystemPasswordChar = true;
            // 
            // password_field
            // 
            this.password_field.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_field.Location = new System.Drawing.Point(254, 240);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(450, 63);
            this.password_field.TabIndex = 12;
            this.password_field.UseSystemPasswordChar = true;
            // 
            // login_field
            // 
            this.login_field.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_field.Location = new System.Drawing.Point(254, 129);
            this.login_field.Multiline = true;
            this.login_field.Name = "login_field";
            this.login_field.Size = new System.Drawing.Size(450, 80);
            this.login_field.TabIndex = 11;
            // 
            // new_user_button
            // 
            this.new_user_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_user_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.new_user_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_user_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_user_button.Location = new System.Drawing.Point(117, 465);
            this.new_user_button.Name = "new_user_button";
            this.new_user_button.Size = new System.Drawing.Size(161, 50);
            this.new_user_button.TabIndex = 10;
            this.new_user_button.Text = "Добавить";
            this.new_user_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.new_user_button.Click += new System.EventHandler(this.new_user_button_Click);
            // 
            // cansel
            // 
            this.cansel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cansel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cansel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cansel.Location = new System.Drawing.Point(439, 465);
            this.cansel.Name = "cansel";
            this.cansel.Size = new System.Drawing.Size(161, 50);
            this.cansel.TabIndex = 5;
            this.cansel.Text = "Отмена";
            this.cansel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cansel.Click += new System.EventHandler(this.cansel_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.header.Controls.Add(this.Name_of_window);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(716, 121);
            this.header.TabIndex = 10;
            // 
            // Name_of_window
            // 
            this.Name_of_window.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name_of_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Name_of_window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name_of_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_of_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_of_window.Location = new System.Drawing.Point(76, 3);
            this.Name_of_window.Name = "Name_of_window";
            this.Name_of_window.Size = new System.Drawing.Size(360, 115);
            this.Name_of_window.TabIndex = 11;
            this.Name_of_window.Text = "Новый пользователь";
            this.Name_of_window.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork_att_1.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(594, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 37);
            this.label2.TabIndex = 15;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Пароль еще раз";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Шеф-повар",
            "Менеджер"});
            this.status.Location = new System.Drawing.Point(411, 47);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(293, 54);
            this.status.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(247, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Статус";
            // 
            // New_user_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 686);
            this.Controls.Add(this.BackGr);
            this.Controls.Add(this.header);
            this.Name = "New_user_window";
            this.Text = "New_user_window";
            this.BackGr.ResumeLayout(false);
            this.BackGr.PerformLayout();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGr;
        private System.Windows.Forms.Label new_user_button;
        private System.Windows.Forms.Label cansel;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_of_window;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.TextBox login_field;
        private System.Windows.Forms.TextBox doublicate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox status;
    }
}