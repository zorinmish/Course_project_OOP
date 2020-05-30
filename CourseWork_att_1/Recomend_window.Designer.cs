namespace CourseWork_att_1
{
    partial class Recomend_window
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
            this.recom = new System.Windows.Forms.Label();
            this.Dinner_for_family = new System.Windows.Forms.Label();
            this.Dish_of_day = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackGr.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGr
            // 
            this.BackGr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BackGr.Controls.Add(this.Dinner_for_family);
            this.BackGr.Controls.Add(this.Dish_of_day);
            this.BackGr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGr.Location = new System.Drawing.Point(0, 161);
            this.BackGr.Name = "BackGr";
            this.BackGr.Size = new System.Drawing.Size(978, 533);
            this.BackGr.TabIndex = 5;
            // 
            // recom
            // 
            this.recom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.recom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recom.Location = new System.Drawing.Point(169, 0);
            this.recom.Name = "recom";
            this.recom.Size = new System.Drawing.Size(276, 161);
            this.recom.TabIndex = 8;
            this.recom.Text = "Рекомендации";
            this.recom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dinner_for_family
            // 
            this.Dinner_for_family.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dinner_for_family.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Dinner_for_family.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dinner_for_family.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dinner_for_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dinner_for_family.Location = new System.Drawing.Point(513, 48);
            this.Dinner_for_family.Name = "Dinner_for_family";
            this.Dinner_for_family.Size = new System.Drawing.Size(400, 120);
            this.Dinner_for_family.TabIndex = 7;
            this.Dinner_for_family.Text = "Ужин на четверых";
            this.Dinner_for_family.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dish_of_day
            // 
            this.Dish_of_day.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dish_of_day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Dish_of_day.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dish_of_day.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dish_of_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dish_of_day.Location = new System.Drawing.Point(65, 48);
            this.Dish_of_day.Name = "Dish_of_day";
            this.Dish_of_day.Size = new System.Drawing.Size(400, 120);
            this.Dish_of_day.TabIndex = 6;
            this.Dish_of_day.Text = "Блюдо дня";
            this.Dish_of_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.header.Controls.Add(this.recom);
            this.header.Controls.Add(this.pictureBox1);
            this.header.Controls.Add(this.settings);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(978, 161);
            this.header.TabIndex = 4;
            // 
            // settings
            // 
            this.settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settings.Location = new System.Drawing.Point(770, 59);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(174, 46);
            this.settings.TabIndex = 5;
            this.settings.Text = "Вернуться";
            this.settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork_att_1.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Recomend_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.BackGr);
            this.Controls.Add(this.header);
            this.Name = "Recomend_window";
            this.Text = "Recomend_window";
            this.BackGr.ResumeLayout(false);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGr;
        private System.Windows.Forms.Label recom;
        private System.Windows.Forms.Label Dinner_for_family;
        private System.Windows.Forms.Label Dish_of_day;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label settings;
    }
}