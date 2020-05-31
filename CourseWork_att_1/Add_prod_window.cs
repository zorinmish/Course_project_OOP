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
    public partial class Add_prod_window : Form
    {
        public Add_prod_window()
        {
            InitializeComponent();
        }

        private void cansel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void new_user_button_Click(object sender, EventArgs e)
        {
            //Adding new products;
            MessageBox.Show("Продукты успешно добавлены!");
            this.Close();
        }
    }
}
