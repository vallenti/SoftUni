using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Path3D p = new Path3D();
            p.AddPoint(new Point3D(1, 2, 3));
            p.AddPoint(new Point3D(3, 4, 5));
            p.AddPoint(new Point3D(5, 6, 7));
            p.AddPoint(new Point3D(7, 8, 9));
            Storage.SavePath(p, "p.txt");
            Path3D z = Storage.LoadPath("p.txt");
            Console.WriteLine(p);
        }
    }
}
