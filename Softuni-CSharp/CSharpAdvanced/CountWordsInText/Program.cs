using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class CountWordsInText
{
    static void Main()
    {
        string input = Console.ReadLine();
        string searchWord = Console.ReadLine();

        input = input.ToLower();
        searchWord = searchWord.ToLower();

        char[] separators = new char[] { ' ', '.', '!', ',', '?', ':', ';', '-', '(', ')', '[', ']', '{', '}', '"', '\'', '“', '”','@','\\','/' };
        string[] text = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        
        int wordsCount = 0;
        foreach (string word in text)
        {
            if (word.Equals(searchWord))
            {
                wordsCount++;
            }
        }

        Console.WriteLine(wordsCount);
    }
}
