using System;

class TestPointClass
{
    static void Main()
    {
        Point a = new Point(20, 10);
        Point b = new Point(-3, 5);
        Point c = new Point(12, 8);
        Point d = new Point();
        Console.WriteLine("{0} {1}",d.X,d.Y);
        d.X = 15;
        d.Y = -2;
        Console.WriteLine("{0} {1}", d.X, d.Y);

    }
}
