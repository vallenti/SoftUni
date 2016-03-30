using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestWord
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] separators = new char[] { ' ', '.', '!', ',', '?', ':', ';', '-', '(', ')', '[', ']', '{', '}', '"', '\'', '“', '”' };
        string[] text = input.Split(separators,StringSplitOptions.RemoveEmptyEntries);
        
        int bestLength = 0;
        string longestWord = string.Empty;
        
        foreach (string word in text)
        {
            if (word.Length > bestLength)
            {
                bestLength = word.Length;
                longestWord = word;
            }
        }

        Console.WriteLine(longestWord);
    }
}

