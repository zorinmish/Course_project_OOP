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
    public partial class Needs_window : Form
    {
        public Needs_window()
        {
            InitializeComponent();
        }

        private void go_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_admin main_adm = new Main_admin();
            main_adm.Show();
        }
    }
}
