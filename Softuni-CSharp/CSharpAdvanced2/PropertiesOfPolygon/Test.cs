using System;

class Test
{
    static void Main()
    {
        int numberOfEdges = int.Parse(Console.ReadLine());
        Polygon shape = new Polygon();

        for (int i = 0; i < numberOfEdges; i++)
        {
            string[] pointCoordinates = Console.ReadLine().Split(' ');
            int x = int.Parse(pointCoordinates[0]);
            int y = int.Parse(pointCoordinates[1]);
            Point edge = new Point(x, y);
            shape.AddEdge(edge);
        }

        Console.WriteLine("perimeter = {0:0.00}", shape.GetPerimeter());
        Console.WriteLine("area = {0:0.00}", shape.GetArea());
    }
}
