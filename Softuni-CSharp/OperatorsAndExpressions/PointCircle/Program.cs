using System;

class PointCircle
{
    static void Main()
    {
        double x = 1;
        double y = 1;
        double circleX = 1;
        double circleY = 1;
        double radius = circleX+1.5;
        double rectTopY = 1;
        double rectTopX = -1;
        double rectBottomY = -1;
        double rectBottomX = 5;

        //check if point is in circle
        double hypotenuse = Math.Pow((x-circleX), 2) + Math.Pow((y-circleY), 2);
        bool inCircle = radius*radius >= hypotenuse;
        Console.WriteLine("in circle?-> "+inCircle);

        //check if point is in rectangle
        bool inRectangle = x >= rectTopX && x <= rectBottomX && y >= rectBottomY && y <= rectTopY;
        Console.WriteLine("in rectangle?->"+inRectangle);

        //check if point is in circle and outside of rectangle
        bool checkPoint = inCircle && (!inRectangle);
        Console.WriteLine(checkPoint);
    }
}

