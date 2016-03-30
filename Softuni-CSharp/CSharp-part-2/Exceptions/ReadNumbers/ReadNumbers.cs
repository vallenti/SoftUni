using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumbers
{
    class ReadNumbers
    {
        static int counter = 1;
        static int ReadNumber(int start, int end)
        {
            int num=0;
            while (counter <= 10)
            {
                Console.Write("input number{0} = " ,counter);
                num = int.Parse(Console.ReadLine());
                counter++;
                if (num < start || num > end)
                {
                    throw new ArgumentOutOfRangeException("number is not in the limits");
                }
                return ReadNumber(num, end);
            }
            return ReadNumber(num, end);
            
        }
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            try
            {
                ReadNumber(start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid number");
            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
