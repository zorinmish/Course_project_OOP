using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
   public  class Chef
    {
        public Chef(string log, string pass)
        {
            Login = log;
            Password = pass;
        }
        public string Login { private set; get; }
        public string Password { private set; get; }
    }
}
