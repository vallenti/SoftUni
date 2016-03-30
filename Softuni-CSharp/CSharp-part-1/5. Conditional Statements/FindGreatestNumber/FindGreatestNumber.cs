using System;

class FindGreatestNumber
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        if (a > b && a > c && a > d && a > e)
        {
            Console.WriteLine("Greatest number: " + a);
        }
        else if (b > c && b > d && b > e)
        {
            Console.WriteLine("Greatest number: " + b);
        }
        else if (c > d && c > e)
        {
            Console.WriteLine("Greatest number: " + c);
        }
        else if (d > e)
        {
            Console.WriteLine("Greatest number: " + d);
        }
        else
        {
            Console.WriteLine("Greatest number: " + e);            
        }
    }
}
