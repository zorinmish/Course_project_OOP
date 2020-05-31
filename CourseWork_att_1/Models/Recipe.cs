using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Products = new List<Portion>();
            Actions = new List<Action>();
        }
        public Recipe(string name, List<Portion> products, List<Action> actions, string serv)
        {
            Name = name;
            Products = products;
            Actions = actions;
            Serving = serv;
            Price = 0;
            Total_Time = 0;
            foreach(var portion in products)
            {
                Price += portion.Product.Price * portion.number;
            }
            foreach(var t in actions)
            {
                Total_Time += t.Time_in_minutes;
            }
        }
        public string Name { set; get; }
        public List<Portion> Products { set; get; }
        public List<Action> Actions { set; get; }
        public string Serving { set; get; }
        public double Price { set; get; }
        public int Total_Time { set; get; }
    }
}
