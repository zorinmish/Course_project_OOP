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
    public partial class Request_form_chef_window : Form
    {
        public Request_form_chef_window()
        {
            InitializeComponent();
        }

        private void cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_request_button_Click(object sender, EventArgs e)
        {
            //adding new recipe
            this.Close();
        }
    }
}
