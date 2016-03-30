using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            //IEnumberable<char>
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();

            //ICloneable
            StringDisperser sd = stringDisperser.Clone() as StringDisperser;
            Console.WriteLine(Object.ReferenceEquals(stringDisperser, sd));

            //IComparable<StringDisperser>
            StringDisperser s = new StringDisperser("abc", "cba");
            List<StringDisperser> list = new List<StringDisperser>() { stringDisperser, sd, s };
            Console.WriteLine("\n---Unsorted:");
            list.ForEach(x => Console.WriteLine(x));
            list.Sort();
            Console.WriteLine("\n---Sorted:");
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
