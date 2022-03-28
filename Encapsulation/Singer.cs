using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Singer
    {
        private string _name;
        private string _surname;
        private int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <= 100)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length <= 100)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 170)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}
