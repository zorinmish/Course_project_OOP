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
    public partial class New_recipe_window : Form
    {
        public New_recipe_window()
        {
            InitializeComponent();
        }

        private void cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_recipe_button_Click(object sender, EventArgs e)
        {
            //adding new recipe
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void New_recipe_window_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void RequiredValidate(Control c, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(c.Text))
            {
                c.BackColor = Color.Pink;
                e.Cancel = true;
            }
        }
    }
}
