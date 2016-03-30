using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        static void Main()
        {
            //string file = Console.ReadLine();
            string fileName = "D:\\School & Work\\C#\\test.txt";
            string content = "";
            try
            {
                content = System.IO.File.ReadAllText(fileName);
                Console.WriteLine(content);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Directory of file could not be found.");
            }
            catch (System.UnauthorizedAccessException)
            {
                Console.WriteLine("You dont have permission to open this file");
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File was not found in directory {0}", fileName);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No file path is given");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The entered file path is too long - 248 characters are the maximum!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Invalid file path format!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
        }
    }
}
