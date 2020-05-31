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
    public partial class New_user_window : Form
    {
        private Users users = new Users();
        public New_user_window()
        {
            InitializeComponent();
            users.Load();
            this.password_field.Size = new Size(this.password_field.Size.Width, 80);
            this.doublicate.Size = new Size(this.password_field.Size.Width, 80);
            
        }

        private void cansel_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_admin main_adm = new Main_admin();
            main_adm.Show();
        }

        private void new_user_button_Click(object sender, EventArgs e)
        {
            if (this.doublicate.Text != this.password_field.Text)
            {
                MessageBox.Show("Пароль введен с ошибкой");
                login_field.Text = "";
                password_field.Text = "";
                doublicate.Text = "";
            }
            else
            {
                string result = users.Check(login_field.Text, password_field.Text);
                if (result == "adm" || result == "che" || result == "Wrong_pas")
                {
                    MessageBox.Show("Пользователь уже существует");
                    login_field.Text = "";
                    password_field.Text = "";
                    doublicate.Text = "";
                } else
                {
                    if (status.SelectedIndex == 1)
                    {
                        Admin admin = new Admin(login_field.Text, password_field.Text);
                        users.Admins.Add(admin);
                        MessageBox.Show("Пользователь успешно добавлен");
                        users.Save();
                        this.Close();
                        Main_admin main_adm = new Main_admin();
                        main_adm.Show();
                    } else
                    {
                        if (status.SelectedIndex == 0)
                        {
                            Chef chef = new Chef(login_field.Text, password_field.Text);
                            users.Chefs.Add(chef);
                            MessageBox.Show("Пользователь успешно добавлен");
                            users.Save();
                            this.Close();
                            Main_admin main_adm = new Main_admin();
                            main_adm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Выберите статус");
                        }

                    }
                }
            }
        }

       
    }
}
