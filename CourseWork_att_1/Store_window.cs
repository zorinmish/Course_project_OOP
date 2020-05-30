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
    public partial class Store_window : Form
    {
        public Store_window()
        {
            InitializeComponent();
            var store = new Store();
            store.FillTestData(100);

            productBindingSource.DataSource = store.Products;
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_chef ch = new Main_chef();
            ch.Show();
        }

        private void new_recipe_button_Click(object sender, EventArgs e)
        {
            Request_form_chef_window req_form_chef = new Request_form_chef_window();
            req_form_chef.ShowDialog();
        }
    }
}
