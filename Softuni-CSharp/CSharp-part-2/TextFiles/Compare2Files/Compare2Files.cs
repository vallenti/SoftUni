using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare2Files
{
    class Compare2Files
    {
        static void Main()
        {
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            int countEqualsLines = 0;
            int countDifferentLines = 0;
            bool diffNumberOfLines = false;
            try
            {
                StreamReader reader1 = new StreamReader(file1);
                StreamReader reader2 = new StreamReader(file2);
                using (reader1)
                {
                    using (reader2)
                    {

                        string line1 = reader1.ReadLine();
                        string line2 = reader2.ReadLine();
                        while (line1 != null && line2 != null)
                        {
                            if (line1 == line2)
                            {
                                countEqualsLines++;
                            }
                            else
                            {
                                countDifferentLines++;
                            }
                            line1 = reader1.ReadLine();
                            line2 = reader2.ReadLine();
                        }
                        if((line1 != null && line2 == null)||
                            (line1 == null && line1 != null))
                        {
                            diffNumberOfLines = true;
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
            if (diffNumberOfLines)
            {
                Console.WriteLine("There are different number of lines in both files");
            }
            else
            {
                Console.WriteLine(countEqualsLines);
                Console.WriteLine(countDifferentLines);
            }
        }
    }
}
