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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();

            this.password_field.Size = new Size(this.password_field.Size.Width, 80);
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void login_MouseEnter(object sender, EventArgs e)
        {
            login.BackColor = Color.FromArgb(224, 38, 38);
        }


        private void login_MouseLeave(object sender, EventArgs e)
        {
            login.BackColor = Color.FromArgb(252, 50, 50);
        }

        private void clear_MouseEnter(object sender, EventArgs e)
        {
            clear.BackColor = Color.FromArgb(224, 38, 38);
        }

        private void clear_MouseLeave(object sender, EventArgs e)
        {
            clear.BackColor = Color.FromArgb(252, 50, 50);
        }

   

        Point last_point;
        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - last_point.X;
                this.Top += e.Y - last_point.Y;
            }
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            last_point = new Point(e.X, e.Y);
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (login_field.Text == "1" && password_field.Text == "1")
            {
                login_field.Text = "";
                password_field.Text = "";
                this.Hide();
                Main_chef main_chef = new Main_chef();
                main_chef.ShowDialog();
            } else
            {
                if (login_field.Text == "2" && password_field.Text == "2")
                {
                    login_field.Text = "";
                    password_field.Text = "";
                    this.Hide();
                    Main_admin main_adm = new Main_admin();
                    main_adm.Show();
                } 
                else
                {
                    MessageBox.Show("No");
                }
            }
        }
    }
}
