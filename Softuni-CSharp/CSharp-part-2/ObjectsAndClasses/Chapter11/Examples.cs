using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chapter11.Chapter_11;

namespace Chapter11
{
    class Examples
    {
        static void Main(string[] args)
        {
            Cat[] catArray = new Cat[10];
            for (int i = 0; i < 10; i++)
            {
                catArray[i] = new Cat(Sequence.NextValue(i));
            }
            foreach (var cat in catArray)
            {
                cat.SayMiau();
            }
        }
    }
}
