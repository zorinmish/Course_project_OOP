namespace CourseWork_att_1
{
    partial class Store_window
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
            this.components = new System.ComponentModel.Container();
            this.BackGr = new System.Windows.Forms.Panel();
            this.Store = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.new_recipe_button = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.go_back = new System.Windows.Forms.Label();
            this.productGrit = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackGr.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGrit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackGr
            // 
            this.BackGr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BackGr.Controls.Add(this.productGrit);
            this.BackGr.Controls.Add(this.menuStrip1);
            this.BackGr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackGr.Location = new System.Drawing.Point(0, 161);
            this.BackGr.Name = "BackGr";
            this.BackGr.Size = new System.Drawing.Size(978, 533);
            this.BackGr.TabIndex = 9;
            // 
            // Store
            // 
            this.Store.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Store.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Store.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Store.Location = new System.Drawing.Point(170, 0);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(269, 161);
            this.Store.TabIndex = 7;
            this.Store.Text = "Склад";
            this.Store.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.header.Controls.Add(this.Store);
            this.header.Controls.Add(this.new_recipe_button);
            this.header.Controls.Add(this.pictureBox2);
            this.header.Controls.Add(this.go_back);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(978, 161);
            this.header.TabIndex = 8;
            // 
            // new_recipe_button
            // 
            this.new_recipe_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.new_recipe_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.new_recipe_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_recipe_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.new_recipe_button.Location = new System.Drawing.Point(440, 55);
            this.new_recipe_button.Name = "new_recipe_button";
            this.new_recipe_button.Size = new System.Drawing.Size(227, 50);
            this.new_recipe_button.TabIndex = 10;
            this.new_recipe_button.Text = "Отправить запрос";
            this.new_recipe_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.new_recipe_button.Click += new System.EventHandler(this.new_recipe_button_Click);
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
            // productGrit
            // 
            this.productGrit.AutoGenerateColumns = false;
            this.productGrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGrit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn});
            this.productGrit.DataSource = this.productBindingSource;
            this.productGrit.Location = new System.Drawing.Point(12, 53);
            this.productGrit.Name = "productGrit";
            this.productGrit.RowHeadersWidth = 62;
            this.productGrit.RowTemplate.Height = 28;
            this.productGrit.Size = new System.Drawing.Size(718, 455);
            this.productGrit.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitDataGridViewTextBoxColumn.Width = 150;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CourseWork_att_1.Models.Product);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // Store_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.BackGr);
            this.Controls.Add(this.header);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Store_window";
            this.Text = "Store_window";
            this.BackGr.ResumeLayout(false);
            this.BackGr.PerformLayout();
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGrit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGr;
        private System.Windows.Forms.Label Store;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label new_recipe_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label go_back;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productGrit;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
    }
}