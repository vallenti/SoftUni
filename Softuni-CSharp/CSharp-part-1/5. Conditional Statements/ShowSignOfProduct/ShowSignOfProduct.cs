using System;

class ShowSignOfProduct
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if ((a < 0 && b < 0) || (a < 0 && c < 0) || (b < 0 && c < 0))
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

