using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    internal class Software
    {
        private string _name;
        private string _manufacturer;
        private bool _isPaid;

        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    return "Ошибка! Пустое поле Name";
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

        public string Manufacturer
        {
            get
            {
                if (string.IsNullOrEmpty(_manufacturer))
                {
                    return "Ошибка! Пустое поле Manufacturer";
                }
                else
                {
                    return _manufacturer;
                }
            }
            set
            {
                _manufacturer = value;
            }
        }

        public bool IsPaid
        {
            get { return _isPaid; }
            set { _isPaid = value; }
        }

        public Software() { }

        public Software(string name, string manufacturer, bool isPaid)
        {
            Name = name;
            Manufacturer = manufacturer;
            IsPaid = isPaid;
        }

        public void DisplayInfo()
        {
            WriteLine($"Название: {Name}");
            WriteLine($"Производитель: {Manufacturer}");
            WriteLine($"Платное: {IsPaid}");
        }

        public void TogglePaidStatus()
        {
            IsPaid = !IsPaid;
        }

        public bool IsFree(string targetManufacturer)
        {
            return !IsPaid && Manufacturer == targetManufacturer;
        }
    }
}

