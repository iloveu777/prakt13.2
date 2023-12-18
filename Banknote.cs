using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Console;


namespace ConsoleApp2
{
    internal class Banknote
    {
        string _name;
        int _den {get;}
        int _count;
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


        public int Count
        {
            get
            {
                return _count;
            }

            set
            {
                _count =  (value < 0) ? 0 : value;
            }
        }
        public Banknote() { }
        public Banknote(string name, int den, int count)
        {
            Name = name;
            _den = den;
            Count = count;
        }
        public void Print()
        {
            WriteLine($"Название банкноты: {_name}, номинал банкноты: {_den}, кол-во банкнот: {_count}");
        }
        public void AddCount(int a)
        {
            Write("Хотите увеличить или уменьшить число купюр? ");
            char c = ReadKey().KeyChar;
            switch (c)
            {
                case '+':
                    WriteLine($"Число купюр({_count}) было увеличено на {a}.");
                    _count += a;
                    Print();
                    break;
                case '-':
                    WriteLine($"Число купюр({_count}) было уменьшено на {a}.");
                    _count -= a;
                    Print();
                    break;
            }
            
        }
        public void Buy(int a)
        {
            int all = _den * _count;
            if (all >= a)
            {
                WriteLine("Покупка возможна");
            }
            else
            {
                WriteLine("Денег нет, но вы держитесь...");
            }
        }
    }
}
