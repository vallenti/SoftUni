using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class Point3D
    {
        private int x;
        private int y;
        private int z;
        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public Point3D(int x, int y)
            : this(x, y, 0)
        {
        }

        public Point3D(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public static Point3D StartingPoint{get;set;}

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
