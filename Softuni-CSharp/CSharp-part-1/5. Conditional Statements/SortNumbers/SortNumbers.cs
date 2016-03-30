using System;

class SortNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        //find the biggest number
        if (a > b && a > c)
        {
            a = a;     //if a is biggest it stays in its place
        }
        else if (b > c) //if b is biggest switch places with a
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        else //if c is biggest switch places with a
        {
            a = a + c;
            c = a - c;
            a = a - c;
        }

        //if c is bigger than b, b and c switch places
        if (b < c)
        {
            b = b + c;
            c = b - c;
            b = b - c;
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}

