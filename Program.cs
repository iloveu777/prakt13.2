using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Edition ed1 = new Edition("Метро","Глуховский",2100,false);
            /* ed1.Year = 1;
             ed1.AuthorSurname = null;
             ed1.Name = null;*/
            //ed1.Year = 2100;
            //Edition ed = new Edition("","",0, true);
            //ed.IsPaper(ed);
            /*  ed1.IsPaper(ed1);
              ed1.Print();
              ed1.AddYear(1);
              ed1.Print();*/
            /* Banknote euro = new Banknote("euro", 500, 2);
             euro.Print();
             euro.AddCount(5);
             Write("Какую сумму вы хотите раскошелится ? ");
             int a = int.Parse(ReadLine());
             euro.Buy(a);*/
            Software kasp = new Software("Kaspersky", "Kaspersky", true);
            kasp.DisplayInfo();
            kasp.TogglePaidStatus();
            kasp.DisplayInfo();

            bool a = kasp.IsFree("kaspersky");
            if (a == true)
            {
                WriteLine("ПО платное :(\"");
            }
            else
            {
                WriteLine("ПО бесплатное!");
            }
            ReadKey();
        }
    }
}
