using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortList
{
    class SortList
    {
        static void Main()
        {
            string source = "source.txt";
            string output = "output.txt";
            List<string> sortedList = new List<string>();
            try
            {
                StreamReader reader = new StreamReader(source);
                StreamWriter writer = new StreamWriter(output);
                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine();
                        while(line!=null)
                        {
                            sortedList.Add(line);
                            line = reader.ReadLine();
                        }
                        sortedList.Sort();
                        foreach (string name in sortedList)
                        {
                            writer.WriteLine(name);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {

            }
            catch (IOException)
            {

            }
            Console.WriteLine("success");
        }
    }
}
