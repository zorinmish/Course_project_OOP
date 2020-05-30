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
    public partial class Store_with_adding_window : Form
    {
        public Store_with_adding_window()
        {
            InitializeComponent();
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_admin m_adm = new Main_admin();
            m_adm.Show();
        }

        private void new_products_button_Click(object sender, EventArgs e)
        {
            Add_prod_window new_pr = new Add_prod_window();
            new_pr.ShowDialog();
        }
    }
}
