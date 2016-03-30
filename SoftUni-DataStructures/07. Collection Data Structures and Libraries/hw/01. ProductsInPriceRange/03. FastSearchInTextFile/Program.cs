using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Tup.AhoCorasick;

namespace _03.FastSearchInTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = "../../input.txt";
            StreamReader reader = new StreamReader(inputPath);
            string[] searchWords = null;
            StringBuilder text = null;
            using (reader)
            {
                int searchWordsCount = int.Parse(reader.ReadLine());
                searchWords = new string[searchWordsCount];
                for (int i = 0; i < searchWordsCount; i++)
                {
                    searchWords[i] = reader.ReadLine().ToLower();
                }
                int linesCount = int.Parse(reader.ReadLine());
                text = new StringBuilder();
                for (int i = 0; i < linesCount; i++)
                {
                    text.Append(reader.ReadLine().ToLower());
                }
            }

            var search = new AhoCorasickSearch();
            var matches = search.SearchAll(text.ToString(), searchWords);

            Dictionary<string, int> wordOccurances = new Dictionary<string, int>();
            foreach (string word in searchWords)
            {
                wordOccurances[word] = 0;
            }

            foreach (var match in matches)
            {
                string word = match.Match;
                wordOccurances[word]++;
            }

            foreach (var word in wordOccurances)
            {
                Console.WriteLine("{0} -> {1}", word.Key, word.Value);
            }
        }
    }
}
