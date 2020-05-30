using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    class Supply
    {
        public Supply(List<Portion> por)
        {
            Portions = por;
            dt = DateTime.Now;
        }

        List<Portion> Portions;
        DateTime dt; 
    }
}
