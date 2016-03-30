using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CountNames
{
    static void Main()
    {
        List<string> names = new List<string>(Console.ReadLine().Split(' '));
        Dictionary<string, int> countedNames = new Dictionary<string, int>();

        foreach (string name in names)
        {
            if (countedNames.ContainsKey(name))
            {
                countedNames[name]++;
            }
            else
            {
                countedNames.Add(name, 1);
            }
        }

        foreach (var letter in countedNames.OrderBy(i => i.Key))
        {
            Console.WriteLine(letter.Key + " -> " + letter.Value);
        }
    }
}

