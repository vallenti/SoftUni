using System;

class FindBiggestNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a > b && a > c)
        {
            Console.WriteLine("Biggest number is "+a);
        }
        else if (b > c)
        {
            Console.WriteLine("Biggest number is "+b);
        }
        else
        {
            Console.WriteLine("Biggest number is "+c);
        }
    }
}