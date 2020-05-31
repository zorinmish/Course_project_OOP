using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    public class Portion
    {
        public Portion(Product prod, double num)
        {
            Product = prod;
            number = num;
            expiration_date = DateTime.Now.AddDays(Product.Expiration_time_days);
        }
        public Product Product;
        public double number;
        public DateTime expiration_date;
    }
}
