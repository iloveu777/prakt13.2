using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApp2
{
    internal class Edition
    {
        private string _name;
        private string _AuthorSurname;
        private int _year;
        private bool Paper { get; set; }
        public static int count = 0;
        public string Name
        {
            get
            {
                if (String.IsNullOrEmpty(_name))
                {
                    return "Ошибка! пустое поле Name";
                }
                else
                {
                    return _name;
                }
            } 

            set
            {
                _name = value;
            }
        }
        public string AuthorSurname
        {
            get 
            
            {
                if (String.IsNullOrEmpty(_AuthorSurname))
                {
                    return"Ошибка! пустое поле AuthorSurname";
                }
                else
                {
                    return _AuthorSurname;
                }
                
                
            } 

            set
            {
                _AuthorSurname = value;
            }
        }

        public int Year
        {
            get => _year;
            set { _year = (value > 2000) ? 0: value; }
            //set { if (value > 2000 ) 
            //    { WriteLine("ошибка");  } 
            //    else 
            //    { _year = value; } }
        }
        public Edition() { }
        public Edition(string name, string authorSurname, int year, bool paper) 
        {
            Name = name;
            AuthorSurname= authorSurname;
            Year = year;
            Paper = paper;
            count++;
        }
        public void IsPaper(Edition edition)
        {
            if (Paper == true) { WriteLine($"Издание {Name} бумажное"); } else { WriteLine($"Издание {Name} электронное "); }
        }
        public void AddYear(int year) 
        {
        Year =+ year;
        }
        public void Print()
        {
            WriteLine($"Название: {_name}, фамилия автора: {_AuthorSurname}, год издания: {_year}");
            Write(count);      
        }
    }
}
