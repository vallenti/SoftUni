using System;

class FindGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        //method by substraction
        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        Console.WriteLine(a);

        //method by division
        int remainder=1;
        if (a < b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        while(remainder!=0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }
        Console.WriteLine(a);
    }
}
