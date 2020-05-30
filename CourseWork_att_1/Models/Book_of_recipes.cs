using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    class Book_of_recipes
    {
        public Book_of_recipes()
        {
            Products = new List<Product>();
            Recipes = new List<Recipe>();
            Chefs = new List<Chef>();
        }
        public void FillTestData(int n)
        {
            
            Chefs = new List<Chef>();
            for (int i = 0; i < n; ++i)
            {
                Chefs.Add(new Chef($"Chef{i}", "123"));
            }
            Products = new List<Product>();
            for (int i = 0; i < n; ++i)
            {
                Products.Add(new Product(i, $"Product{i}", "gr", i * 100, (i + 15) % 7 + 1));
            }
            Recipes = new List<Recipe>();
            
            for (int i = 0; i < n; ++i) 
            {
                string name = $"Recipe{i + 1}";
                var por = new List<Portion>();
                for (int j = 0; j < 3; ++j)
                {
                    por.Add(new Portion(Products[(i + j) % n], 5 + j));
                }
                var act = new List<Action>();
                for (int j = 0; j<3; ++j)
                {
                    act.Add(new Action($"Action{j+1}Action{j + 1}Action{j + 1}", j*5+5));
                }
                string serving = $"Serving like {i+1} times";
                Recipes.Add(new Recipe(name,por, act, serving));
            }
        }
        public void Save()
        {
            SaveProducts();
            SaveChefs();
            SaveRecipes();
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
        private void SaveChefs()
        {
            using (var wr = new StreamWriter("chefs.txt"))
            {
                wr.WriteLine(Chefs.Count);
                foreach (var c in Chefs)
                {
                    wr.WriteLine(c.Login);
                    wr.WriteLine(c.Password);
                }
            }
        }
        private void SaveRecipes()
        {
            using (var wr = new StreamWriter("recipes.txt"))
            {
                wr.WriteLine(Recipes.Count);
                foreach(var recipe in Recipes)
                {
                    wr.WriteLine(recipe.Name);
                    wr.WriteLine(recipe.Serving);
                    wr.WriteLine(recipe.Products.Count);
                    foreach(var port in recipe.Products)
                    {
                          wr.WriteLine(port.number);
                          wr.WriteLine(port.Product.ID);
                    }
                    wr.WriteLine(recipe.Actions.Count);
                    foreach(var port in recipe.Actions)
                    {
                        wr.WriteLine(port.Description);
                        wr.WriteLine(port.Time_in_minutes);
                    }
                }
            }
        }

        public void Load()
        {
            LoadProducts();
            LoadChefs();
            LoadRecipes();
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
                for (int i = 0; i < n; ++i)
                {
                    Chefs.Add(new Chef(rd.ReadLine(), rd.ReadLine()));
                }
            }
        }
        private void LoadRecipes()
        {
            using (var rd = new StreamReader("recipes.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                Recipes.Clear();
                for(int i = 0; i<n; ++i)
                {
                    string name = rd.ReadLine();
                    string serv = rd.ReadLine();
                    var ps = ReadPortions(rd);
                    List<Action> act = new List<Action>();
                    int num = Convert.ToInt32(rd.ReadLine());
                    for(int j = 0;j<num; ++j)
                    {
                        act.Add(new Action(rd.ReadLine(), Convert.ToInt32(rd.ReadLine())));
                    }
                    Recipes.Add(new Recipe(name, ps,act, serv));
                }
            }
        }


        private List<Portion> ReadPortions(StreamReader sr)
        {
            int n = Convert.ToInt32(sr.ReadLine());
            var por = new List<Portion>();
            for (int i = 0; i < n; ++i)
            {
                var amount = Convert.ToDouble(sr.ReadLine());
                var prodID = Convert.ToInt32(sr.ReadLine());

                por.Add(new Portion(GetProductById(prodID), amount));
            }
            return por;
        }
        private Product GetProductById(int productId) =>
                Products.Single(p => p.ID == productId);


        public List<Product> Products { private set; get; }
        public List<Recipe> Recipes { private set; get; }
        public List<Chef> Chefs { private set; get; }
    }
}
