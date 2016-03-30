using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleArea
{
    class TriangleArea
    {
        //calculates area using side and its altitute
        static double Area(double side, double altitude)
        {
            double area = (side * altitude) / 2;
            return area;
        }

        //calculates area using 2 sides and angle between them
        static double Area(double sideA, double sideB, double angle)
        {
            double area = (sideA * sideB * Math.Sin(angle)) / 2;
            return area;
        }

        //calculates are using 3 sides
        static double Area(float sideA, float sideB, float sideC)
        {

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            return area;
        }

        static void Main()
        {
            Console.WriteLine(Area(5, 3));
            Console.WriteLine(Area(5, 4, 20.0));
            Console.WriteLine(Area(5, 4, 3));
        }
    }
}