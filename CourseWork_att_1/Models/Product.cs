using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    public class Product
    {
        public Product(int i, string name, string unit, double price, int time){
            ID = i;
            Name = name;
            Unit = unit;
            Price = price;
            Expiration_time_days = time;
        }
        public int ID {  set; get; }
        public string Name {  set; get; }
        public string Unit {  set; get; }
        public double Price {  set; get; }
        public int Expiration_time_days {  set; get; }
    }
}
