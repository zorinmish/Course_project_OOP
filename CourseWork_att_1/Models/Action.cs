using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    class Action
    {
        public Action(string desc, int time)
        {
            Description = desc;
            Time_in_minutes = time;
        }
        public string Description { private set; get; }
        public int Time_in_minutes { private set; get; }

    }
}
