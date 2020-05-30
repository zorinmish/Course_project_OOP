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
    public partial class Recomend_window : Form
    {
        public Recomend_window()
        {
            InitializeComponent();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_chef m_ch = new Main_chef();
            m_ch.Show();
        }
    }
}
