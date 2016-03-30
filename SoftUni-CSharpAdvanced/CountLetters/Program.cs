using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountLetters
{
    static void Main()
    {
        List<string> letters = new List<string>(Console.ReadLine().Split(' '));
        Dictionary<char,int> countedLetters = new Dictionary<char, int>();

        foreach (string letter in letters)
        {
            char symbol = letter[0];
            if (countedLetters.ContainsKey(symbol))
            {
                countedLetters[symbol]++;
            }
            else
            {
                countedLetters.Add(symbol, 1);
            }
        }

        foreach (var letter in countedLetters.OrderBy(i => i.Key))
        {
            Console.WriteLine(letter.Key+" -> "+letter.Value);
        }
    }
}

