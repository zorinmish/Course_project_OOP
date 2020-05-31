namespace CourseWork_att_1
{
    partial class Needs_window
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
            this.header = new System.Windows.Forms.Panel();
            this.Store = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.go_back = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGr
            // 
            this.BackGr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BackGr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGr.Location = new System.Drawing.Point(0, 161);
            this.BackGr.Name = "BackGr";
            this.BackGr.Size = new System.Drawing.Size(978, 533);
            this.BackGr.TabIndex = 11;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.header.Controls.Add(this.Store);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.go_back);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(978, 161);
            this.header.TabIndex = 10;
            // 
            // Store
            // 
            this.Store.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Store.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Store.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Store.Location = new System.Drawing.Point(170, 0);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(410, 161);
            this.Store.TabIndex = 7;
            this.Store.Text = "Пополнить запасы:";
            this.Store.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CourseWork_att_1.Properties.Resources.man;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // go_back
            // 
            this.go_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.go_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.go_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.go_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.go_back.Location = new System.Drawing.Point(784, 55);
            this.go_back.Name = "go_back";
            this.go_back.Size = new System.Drawing.Size(161, 50);
            this.go_back.TabIndex = 5;
            this.go_back.Text = "Вернуться";
            this.go_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.go_back.Click += new System.EventHandler(this.go_back_Click);
            // 
            // Needs_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.BackGr);
            this.Controls.Add(this.header);
            this.Name = "Needs_window";
            this.Text = "Needs_window";
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGr;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label Store;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label go_back;
    }
}