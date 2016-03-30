using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertLineNumbers
{
    class InsertLineNumbers
    {
        static void Main()
        {
            string source = "source.txt";
            string output = "output.txt";
            try
            {
                StreamReader reader = new StreamReader(source);
                StreamWriter writer = new StreamWriter(output);
                using (reader)
                {
                    using (writer)
                    {
                        string line = reader.ReadLine();
                        int lineNumber = 1;
                        while (line != null)
                        {
                            writer.WriteLine(lineNumber +" "+ line);
                            line = reader.ReadLine();
                            lineNumber++;
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
        }
    }
}
