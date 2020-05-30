using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    class Product
    {
        public Product(int i, string name, string unit, double price, int time){
            ID = i;
            Name = name;
            Unit = unit;
            Price = price;
            Expiration_time_days = time;
        }
        public int ID { private set; get; }
        public string Name { private set; get; }
        public string Unit { private set; get; }
        public double Price { private set; get; }
        public int Expiration_time_days { private set; get; }
    }
}
