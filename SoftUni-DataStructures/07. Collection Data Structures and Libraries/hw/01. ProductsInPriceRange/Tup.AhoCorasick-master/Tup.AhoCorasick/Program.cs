using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tup.AhoCorasick
{
    class Program
    {
        static void Main(string[] args)
        {
            var search = new AhoCorasickSearch();
            var res = search.SearchAll("ushers", new string[] { "he", "she", "his", "hers" });
            foreach (var r in res)
            {
                Console.WriteLine(r.Match);
            }
            Console.Read();
        }
    }
}
