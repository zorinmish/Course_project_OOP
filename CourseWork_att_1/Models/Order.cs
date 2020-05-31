using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CourseWork_att_1.Models
{
    public class Order
    {
        public Order(List<Portion> por, Chef ch, DateTime date)
        {
            Portions = por;
            Chef = ch;
            Dt = date;
        }
        public List<Portion> Portions { private set; get; }
        public Chef Chef { private set; get; }
        public DateTime Dt { private set; get; } 
    }
}
