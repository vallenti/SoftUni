using System;

class CalculateRectangleArea
{
    static void Main()
    {
        float width = 2.5f;
        float height = 3;
        float perimeter = width * 2 + height * 2;
        float area = width * height;
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}

