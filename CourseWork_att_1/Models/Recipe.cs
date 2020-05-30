using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    class Recipe
    {
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
        public string Name { private set; get; }
        public List<Portion> Products { private set; get; }
        public List<Action> Actions { private set; get; }
        public string Serving { private set; get; }
        public double Price { private set; get; }
        public int Total_Time { private set; get; }
    }
}
