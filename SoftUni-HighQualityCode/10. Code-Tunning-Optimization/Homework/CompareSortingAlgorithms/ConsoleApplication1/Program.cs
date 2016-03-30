using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            ulong f = ulong.Parse(Console.ReadLine());
            ulong t = ulong.Parse(Console.ReadLine());
            ulong p = ulong.Parse(Console.ReadLine());

            decimal availableCakes = f/ c;
            if(availableCakes >= n)
            {
                ulong tc = t * p;
                decimal cp = (tc / (n * 1.0m))* 1.25m;
                Console.WriteLine("All products available, price of a cake: {0:f2}", cp);
            }
            else
            {
                ulong ac = (ulong)availableCakes;
                decimal tfr = n * c;
                decimal kn = tfr - f;
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", ac, kn);
            }
        }
    }
}
