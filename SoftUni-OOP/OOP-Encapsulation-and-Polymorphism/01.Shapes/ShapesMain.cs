using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes
{
    class ShapesMain
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>()
            {
                new Rectangle(5, 5),
                new Rectangle(5, 6),
                new Rhombus(2, 4),
                new Rhombus(3, 2),
                new Circle(2,2,14)
            };
            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine(shape.CalculatePerimeter());
                Console.WriteLine("--------");
            }
        }
    }
}
