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
            Book_of_recipes book = new Book_of_recipes();
            book.FillTestData(10);
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
    }
}
