using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWord
{
    class ReplaceWord
    {
        static void Main(string[] args)
        {
            string inputFile = "source.txt";
            string outputFile = "output.txt";
            StringBuilder replacedText = new StringBuilder();
            string searchWord = " start ";
            string replaceWord = " finish ";
            try
            {
                StreamReader reader = new StreamReader(inputFile);
                StreamWriter writer = new StreamWriter(outputFile);
                using (reader)
                {
                    using (writer)
                    {
                        string text = reader.ReadToEnd();
                        replacedText.Append(text);
                        replacedText = replacedText.Replace(searchWord, replaceWord);
                        writer.Write(replacedText.ToString());
                    }
                }
            }
            catch(FileNotFoundException)
            {

            }
        }
    }
}
