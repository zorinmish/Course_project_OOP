using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    class Event
    {
        public Event(List<Portion> portions, Chef chef)
        {
            Portions = portions;
            Chef = chef;
            Dt = DateTime.Now;
        }
        public List<Portion> Portions { private set; get; }
        public Chef Chef { private set; get; }
        public DateTime Dt { private set; get; }
    }
}
