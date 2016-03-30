using System;

class CheckIfPointIsInCircle
{
    static void Main()
    {
        //input coordinates (x,y)
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        //find if point is in the circle
        int cirlce = x * x + y * y;
        bool inCircle = Math.Sqrt(cirlce) <= 5;
        Console.WriteLine(inCircle);
    }
}

