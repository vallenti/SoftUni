using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSymbols
{
    class CountSymbols
    {
        static void Main()
        {
            string text = Console.ReadLine();
            HashTable<char, int> symbolsCount = new HashTable<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];
                if (!symbolsCount.ContainsKey(currentSymbol))
                {
                    symbolsCount.Add(currentSymbol, 0);
                }

                symbolsCount[currentSymbol]++;
            }

            var orderedSymbols = symbolsCount.OrderBy(x => x.Key);
            foreach (var symbol in orderedSymbols)
            {
                Console.WriteLine("{0}: {1} time/s", symbol.Key, symbol.Value);
            }
        }
    }
}
