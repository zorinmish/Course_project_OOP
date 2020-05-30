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
    public partial class New_user_window : Form
    {
        public New_user_window()
        {
            InitializeComponent();
        }

        private void cansel_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_admin main_adm = new Main_admin();
            main_adm.Show();
        }

        private void new_user_button_Click(object sender, EventArgs e)
        {
            //adding new user
            MessageBox.Show("Пользователь успешно добавлен");
            this.Close();
            Main_admin main_adm = new Main_admin();
            main_adm.Show();
        }
    }
}
