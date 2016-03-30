﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Animals
{
    class Frog : Animal
    {
        public Frog(string name, int age, char gender)
            : base(name, age, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("kvak kvak");
        }
    }
}
