﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, 'f')
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("myr myr");
        }
    }
}
