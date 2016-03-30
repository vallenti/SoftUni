using System;

class CheckForPoint
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int cirlce = x * x + 1 + y * y + 1;

        //check if point is in circle
        bool inCircle = Math.Sqrt(cirlce) <= 4;

        //check if point is in the rectangle
        bool inRectangle = ((x>-1 && x<5) &&(y<1 && y>-1));

        //check if point is in the circle but not in rectangle
        Console.WriteLine(inCircle && !inRectangle);
    }
}

