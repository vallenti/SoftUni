using System;


class FindMultiplicationSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            int countNegativeSigns = 0;
            if (a < 0)
            {
                countNegativeSigns++;
            }
            if (b < 0)
            {
                countNegativeSigns++;
            }
            if (c < 0)
            {
                countNegativeSigns++;
            }
            if (countNegativeSigns % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}

