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
            this.new_user_button = new System.Windows.Forms.Label();
            this.cansel = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name_of_window = new System.Windows.Forms.Label();
            this.BackGr.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGr
            // 
            this.BackGr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BackGr.Controls.Add(this.new_user_button);
            this.BackGr.Controls.Add(this.cansel);
            this.BackGr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGr.Location = new System.Drawing.Point(0, 121);
            this.BackGr.Name = "BackGr";
            this.BackGr.Size = new System.Drawing.Size(571, 569);
            this.BackGr.TabIndex = 11;
            // 
            // new_user_button
            // 
            this.new_user_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_user_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.new_user_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_user_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_user_button.Location = new System.Drawing.Point(44, 467);
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
            this.cansel.Location = new System.Drawing.Point(366, 467);
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
            this.header.Size = new System.Drawing.Size(571, 121);
            this.header.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork_att_1.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(448, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Name_of_window
            // 
            this.Name_of_window.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name_of_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Name_of_window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name_of_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Name_of_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_of_window.Location = new System.Drawing.Point(3, 3);
            this.Name_of_window.Name = "Name_of_window";
            this.Name_of_window.Size = new System.Drawing.Size(360, 115);
            this.Name_of_window.TabIndex = 11;
            this.Name_of_window.Text = "Новый пользователь";
            this.Name_of_window.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_user_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 690);
            this.Controls.Add(this.BackGr);
            this.Controls.Add(this.header);
            this.Name = "New_user_window";
            this.Text = "New_user_window";
            this.BackGr.ResumeLayout(false);
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
    }
}