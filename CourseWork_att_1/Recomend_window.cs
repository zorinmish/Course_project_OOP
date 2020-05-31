using CourseWork_att_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork_att_1
{
    public partial class Recomend_window : Form
    {
        public Recomend_window()
        {
            InitializeComponent();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_chef m_ch = new Main_chef();
            m_ch.Show();
        }

        private void Dish_of_day_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.FillTestData(100);
            Book_of_recipes book_Of_Recipes = new Book_of_recipes();
            book_Of_Recipes.FillTestData(100);
            Recipe result = book_Of_Recipes.FindBest(store);
            if (result == null) MessageBox.Show("Недостаточно продуктов для блюда");
            else MessageBox.Show(result.Name);
        }

        private void Dinner_for_family_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.FillTestData(100);
            Book_of_recipes book_Of_Recipes = new Book_of_recipes();
            book_Of_Recipes.FillTestData(100);
            List<Recipe> result = book_Of_Recipes.FindLot(store);
            if (result == null) MessageBox.Show("Недостаточно продуктов для ужина");
            else
            {
                foreach (var rec in result) MessageBox.Show(rec.Name);
            }
        }
    }
}
