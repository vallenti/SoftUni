using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AsynchronousTimer
{
    class Program
    {
        static void Main(string[] args)
        {
            Action action = PrintSomething;
            AsyncTimer timer = new AsyncTimer(action, 3, 100);
            timer.Execute();
            for (int i = 1; i <= 350; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void PrintSomething()
        {
            Console.WriteLine("something looooooooooooooooooooooooooooooooooooooooong and asynchronous");
        }
    }
}
