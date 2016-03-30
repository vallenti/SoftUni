using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class Path3D
    {
        private List<Point3D> path;

        public Path3D()
            : this(new List<Point3D>())
        {
        }
        public Path3D(List<Point3D> path)
        {
            this.Path = path;
        }

        public List<Point3D> Path { get; set; }


        public void AddPoint(Point3D point)
        {
            Path.Add(point);
        }
        public void AddPoints(params Point3D[] points)
        {
            Path.AddRange(points);
        }

        
    }
}
