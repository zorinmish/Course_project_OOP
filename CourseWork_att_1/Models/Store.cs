using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    class Store
    {
        public List<Product> Products { private set; get; }
        public List<Chef> Chefs { private set; get; }
        public List<Portion> Portions { private set; get; }
        public List<Supply> Supplies { private set; get; }
        public List<Order> Orders { private set; get; }
        public Store()
        {
            Products = new List<Product>();
            Chefs = new List<Chef>();
            Portions = new List<Portion>();
            Orders = new List<Order>();
            Supplies = new List<Supply>();
        }
        public void FillTestData(int n)
        {
            Products = new List<Product>();
            for (int i = 0; i<n; ++i)
            {
                Products.Add(new Product(i, $"Product{i}", "gr", i*100,(i+15)%7+1));
            }
            Chefs = new List<Chef>();
            for (int i = 0; i < n; ++i)
            {
                Chefs.Add(new Chef($"Chef{i}", "123"));
            }
            Orders = new List<Order>();
            for(int i = 0; i< n-3; ++i)
            {
                var por = new List<Portion>();
                for(int j = 0; j<3; ++j)
                {
                    por.Add(new Portion(Products[(i + j) % n], 5+j));
                }
                Orders.Add(new Order(por, Chefs[i], DateTime.Now.AddDays(i % 7)));
            }
        }
        public void Save()
        {
            SaveProducts();
            SaveUser();
            SaveOrders();
        }
        private void SaveProducts()
        {
            using (var wr = new StreamWriter("products.txt"))
            {
                wr.WriteLine(Products.Count);
                foreach (var p in Products)
                {
                    wr.WriteLine(p.ID);
                    wr.WriteLine(p.Name);
                    wr.WriteLine(p.Unit);
                    wr.WriteLine(p.Price);
                    wr.WriteLine(p.Expiration_time_days);
                }
            }
        }
        private void SaveUser()
        {
            using (var wr = new StreamWriter("chefs.txt"))
            {
                wr.WriteLine(Chefs.Count);
                foreach(var c in Chefs)
                {
                    wr.WriteLine(c.Login);
                    wr.WriteLine(c.Password);
                }
            }
        }
        private void SaveOrders()
        {
            using (var wr = new StreamWriter("orders.txt"))
            {
                wr.WriteLine(Orders.Count);
                foreach(var o in Orders)
                {
                    wr.WriteLine(o.Chef.Login);
                    wr.WriteLine(o.Dt);
                    wr.WriteLine(o.Portions.Count);
                    foreach (var por in o.Portions)
                    {
                        wr.WriteLine(por.number);
                        wr.WriteLine(por.Product.ID);
                    }
                }
            }

        }
        public void Load()
        {
            LoadProducts();
            LoadChefs();
            LoadOrders();
        }
        private void LoadProducts()
        {
            using (var rd = new StreamReader("products.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                Products.Clear();
                for (int i = 0; i < n; i++)
                {
                    Products.Add(new Product(Convert.ToInt32(rd.ReadLine()), rd.ReadLine(), rd.ReadLine(),
                        Convert.ToDouble(rd.ReadLine()), Convert.ToInt32(rd.ReadLine())));
                }
            }
        }
        private void LoadChefs()
        {
            using (var rd = new StreamReader("chefs.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                Chefs.Clear();
                for(int i = 0; i<n; ++i)
                {
                    Chefs.Add(new Chef(rd.ReadLine(), rd.ReadLine()));
                }
            }
        }
        private void LoadOrders()
        {
            using (var rd = new StreamReader("orders.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                Orders.Clear();
                for(int i = 0; i<n; ++i)
                {

                    var chef_log = rd.ReadLine();
                    var ch = GetChefByLogin(chef_log);
                    var dt = Convert.ToDateTime(rd.ReadLine());
                    var ps = ReadPortions(rd);
                    Orders.Add(new Order(ps,ch,dt));
                }
            }
        }
        
        private Chef GetChefByLogin(string name)
        {
            foreach(var c in Chefs)
            {
                if (c.Login == name) return c;
            }
            throw new Exception();
        }
        private List<Portion> ReadPortions(StreamReader sr)
         {
             int n = Convert.ToInt32(sr.ReadLine());
             var por = new List<Portion>();
             for(int i = 0; i < n; ++i)
             {
                 var amount = Convert.ToDouble(sr.ReadLine());
                 var prodID = Convert.ToInt32(sr.ReadLine());

                 por.Add(new Portion(GetProductById(prodID), amount));
             }
            return por;
         }
        private Product GetProductById(int productId) =>
                Products.Single(p => p.ID == productId);
    }
}
