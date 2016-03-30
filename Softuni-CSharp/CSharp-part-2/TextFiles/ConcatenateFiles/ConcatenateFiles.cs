using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateFiles
{
    class ConcatenateFiles
    {
        static void Main(string[] args)
        {
            string file1 = "file1.txt";
            string file2 = "file2.txt";
            string file3 = "file3.txt";
            try
            {
                StreamReader readerFile1 = new StreamReader(file1);
                StreamReader readerFile2 = new StreamReader(file2);
                StreamWriter writerFile3 = new StreamWriter(file3);
                using (readerFile1)
                {
                    using (readerFile2)
                    {
                        using (writerFile3)
                        {
                            string text1 = readerFile1.ReadToEnd();
                            string text2 = readerFile2.ReadToEnd();
                            writerFile3.Write(text1 + text2);
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
