using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork_att_1.Models;

namespace CourseWork_att_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Book_of_recipes book = new Book_of_recipes();
            book.FillTestData(100);
            book.Save();
            book.Load();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Book_of_recipes_window());
        }
    }
}
