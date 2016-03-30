using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter11.Chapter_11
{
    class Cat
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public Cat(string Name)
        {
            this.name = Name;
        }
        public void SayMiau()
        {
            Console.WriteLine("{0} said miauuu", name);
        }
    }
}
