using System;

class PointInCircle
{
    static void Main()
    {
        float x = -2f;
        float y = 0f;
        int circleX = 0;
        int circleY = 0;
        float radius = 2f;
        float hypotenuse = (float)Math.Sqrt(Math.Pow((x-circleX), 2) + Math.Pow((y-circleY), 2));
        bool inCircle = radius >= hypotenuse;
        Console.WriteLine(inCircle);
    }
}

