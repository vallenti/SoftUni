using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOddLines
{
    class PrintOddLines
    {
        static void Main()
        {
            string filePath = @"D:\School & Work\C#\test.txt";
            try
            {
                StreamReader reader = new StreamReader(filePath);
                using (reader)
                {
                    string line = reader.ReadLine();
                    bool oddLine = true;
                    while (line != null)
                    {
                        if (oddLine)
                        {
                            Console.WriteLine(line);
                            oddLine = false;
                        }
                        else
                        {
                            oddLine = true;
                        }
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("file couldnt be found");
            }
            catch (IOException)
            {
                Console.WriteLine("cannot open file");
            }
        }
    }
}
