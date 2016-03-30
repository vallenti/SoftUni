using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("test");
            list.Add("test1");
            list.Add("test2");
            list.Add("test2");
            Console.WriteLine(list);
            Console.WriteLine(list.Contains("test"));
            Console.WriteLine(list.Contains("dsa"));
            Console.WriteLine(list.IndexOf("test"));
            Console.WriteLine(list.IndexOf("s"));
            Console.WriteLine(list[3]);
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            list.Clear();
            list.Insert(0, "da");
            list.Insert(1, "ne");
            Console.WriteLine(list);

            var type = typeof(CustomList<>);
            var allAttributes = type.GetCustomAttributes(false);
            foreach (var attr in allAttributes)
            {
                var attribute = attr as VersionAttribute;
                if (attribute != null)
                {
                    Console.WriteLine("CustomList<T> version: {0}",attribute);
                }
            }
    }
    }
}
