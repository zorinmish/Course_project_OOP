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
    public partial class Main_admin : Form
    {
        public Main_admin()
        {
            InitializeComponent();
        }

        private void Store_MouseEnter(object sender, EventArgs e)
        {
            Store.BackColor = Color.FromArgb(224, 38, 38);
        }

        private void Store_MouseLeave(object sender, EventArgs e)
        {
            Store.BackColor = Color.FromArgb(252, 50, 50);
        }

        private void Check_MouseEnter(object sender, EventArgs e)
        {
            Check.BackColor = Color.FromArgb(224, 38, 38);
        }

        private void Check_MouseLeave(object sender, EventArgs e)
        {
            Check.BackColor = Color.FromArgb(252, 50, 50);
        }

        private void new_user_MouseEnter(object sender, EventArgs e)
        {
            new_user.BackColor = Color.FromArgb(224, 38, 38);
        }

        private void new_user_MouseLeave(object sender, EventArgs e)
        {
            new_user.BackColor = Color.FromArgb(252, 50, 50);
        }

 

        private void logout_MouseEnter(object sender, EventArgs e)
        {
            logout.BackColor = Color.FromArgb(255, 172, 172);
        }

        private void logout_MouseLeave(object sender, EventArgs e)
        {
            logout.BackColor = Color.FromArgb(255, 192, 192);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form log = (login_form)Application.OpenForms[0];
            log.Show();
        }

        private void Store_Click(object sender, EventArgs e)
        {
            this.Close();
            Store_with_adding_window store_with_adding = new Store_with_adding_window();
            store_with_adding.Show();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            this.Close();
            Needs_window need = new Needs_window();
            need.Show();
        }

        private void new_user_Click(object sender, EventArgs e)
        {
            this.Close();
            New_user_window new_us = new New_user_window();
            new_us.Show();
        }
    }
}
