using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork_att_1.Models;

namespace CourseWork_att_1
{
    public partial class Book_of_recipes_window : Form
    {
        Book_of_recipes book = new Book_of_recipes();
        public Book_of_recipes_window()
        {
            InitializeComponent();
            book.FillTestData(100);
            book.Save();
            recipeBindingSource.DataSource = book.Recipes;

        }

        private void go_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_chef ch = new Main_chef();
            ch.Show();
        }

        private void new_recipe_button_Click(object sender, EventArgs e)
        {
            ////добавление рецепта
            New_recipe_window new_rec = new New_recipe_window();
            new_rec.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book.Load();
            recipeBindingSource.DataSource = book.Recipes;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            book.Save();
        }

        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_recipe_window win = new New_recipe_window();
            win.ShowDialog();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toEdit = dataGridView1.SelectedRows[0].DataBoundItem as Recipe;
            New_recipe_window win = new New_recipe_window(toEdit);
            win.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toDel = dataGridView1.SelectedRows[0].DataBoundItem as Recipe;
            var res = MessageBox.Show($"Удалить {toDel.Name} ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                book.Recipes.Remove(toDel);
                recipeBindingSource.ResetBindings(false);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recipeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Name_of_window_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackGr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
