using System;
using System.Collections.Generic;

class Polygon
{
    private List<Point> edges;

    internal List<Point> Edges
    {
        get { return edges; }
        set { edges = value; }
    }

    public Polygon()
    {
        this.edges = new List<Point>();
    }

    public void AddEdge(Point p)
    {
        edges.Add(p);
    }
    public double GetPerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < edges.Count; i++)
        {
            double distance; //distance between two points
            int partOne, partTwo; // parts of the formula calculating distance just to look nicer
            if (i < edges.Count - 1) 
            {
                partOne = edges[i + 1].X - edges[i].X;
                partTwo = edges[i + 1].Y - edges[i].Y;
            }
            else
            {
                partOne = edges[i].X - edges[0].X;
                partTwo = edges[i].Y - edges[0].Y;
            }
            distance = Math.Sqrt(Math.Pow(partOne, 2) + Math.Pow(partTwo, 2));
            perimeter += distance;
        }
        return perimeter;
    }
    public double GetArea()
    {
        double area = 0;
        for (int i = 0; i < edges.Count; i++)
        {
            double partOne, partTwo;// parts of the formula calculating polygon area
            if (i < edges.Count - 1)
            {
                partOne = edges[i].X * edges[i + 1].Y;
                partTwo = edges[i].Y * edges[i + 1].X;
            }
            else
            {
                partOne = edges[i].X * edges[0].Y;
                partTwo = edges[i].Y * edges[0].X;
            }
            area += (partOne - partTwo);
        }
        return Math.Abs(area/2);
    }
}
