﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, 'm')
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("rrrr rrrr");
        }
    }
}
