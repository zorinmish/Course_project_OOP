using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork_att_1.Models
{
    public class Users
    { 
        public string Check(string log, string pas)
        {
            foreach (var adm in Admins)
            {
                if (adm.Login == log)
                {
                    if (adm.Password == pas)
                    {
                        return "adm";
                    }
                    else
                    {
                        return "Wrong_pas";
                    }
                }
            }
            foreach (var chef in Chefs)
            {
                if (chef.Login == log)
                {
                    if (chef.Password == pas)
                    {
                        return "che";
                    }
                    else
                    {
                        return "Wrong_pas";
                    }
                }
            }
            return "No_such";
        }
        public void Save()
        {
            SaveAdmins();
            SaveChefs();
        }
        private void SaveAdmins()
        {
            using (var wr = new StreamWriter("admins.txt"))
            {
                wr.WriteLine(Admins.Count);
                foreach (var c in Admins)
                {   
                    wr.WriteLine(c.Login);
                    wr.WriteLine(c.Password);
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
        public void Load()
        {
            Admins = new List<Admin>();
            Chefs = new List<Chef>();

            LoadAdmins();
            LoadChefs();
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
        private void LoadAdmins()
        {
            using (var rd = new StreamReader("admins.txt"))
            {
                int n = Convert.ToInt32(rd.ReadLine());
                Admins.Clear();
                for (int i = 0; i < n; ++i)
                {
                    Admins.Add(new Admin(rd.ReadLine(), rd.ReadLine()));
                }
            }
        }

        public List<Admin> Admins { private set; get; }
        public List<Chef> Chefs { private set; get; }
    }
}
