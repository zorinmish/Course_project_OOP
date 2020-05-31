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
    public partial class Main_chef : Form
    {
        public Main_chef()
        {
            InitializeComponent();
        }

        private void Menu_MouseEnter(object sender, EventArgs e)
        {
            Menu.BackColor = Color.FromArgb(224, 38, 38);
        }

        private void Menu_MouseLeave(object sender, EventArgs e)
        {
            Menu.BackColor = Color.FromArgb(252, 50, 50);
        }

        private void Store_MouseEnter(object sender, EventArgs e)
        {
            Store.BackColor = Color.FromArgb(224, 38, 38);
        }

        private void Store_MouseLeave(object sender, EventArgs e)
        {
            Store.BackColor = Color.FromArgb(252, 50, 50);
        }

        private void recom_MouseEnter(object sender, EventArgs e)
        {
            recom.BackColor = Color.FromArgb(224, 38, 38);
        }

        private void recom_MouseLeave(object sender, EventArgs e)
        {
            recom.BackColor = Color.FromArgb(252, 50, 50);
        }

        private void logout_MouseEnter(object sender, EventArgs e)
        {
            logout.BackColor = Color.FromArgb(255, 172, 172);
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.BackColor = Color.FromArgb(255, 192, 192);
        }

       

        private void Menu_Click(object sender, EventArgs e)
        {
            this.Close();
            Book_of_recipes_window book = new Book_of_recipes_window();
            book.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form log =(login_form)Application.OpenForms[0];
            log.Show();
        }

        private void Store_Click(object sender, EventArgs e)
        {
            this.Close();
            Store_window st = new Store_window();
            st.Show();
        }

        private void recom_Click(object sender, EventArgs e)
        {
            this.Close();
            Recomend_window rec_win = new Recomend_window();
            rec_win.Show();
        }
    }
}
