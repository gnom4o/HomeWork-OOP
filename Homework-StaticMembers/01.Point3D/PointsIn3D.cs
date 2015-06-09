using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class PointsIn3D
    {
        static void Main()
        {
           
            Point3D p = new Point3D(3, -2, 1);
            Point3D q = new Point3D(4, -3, 5);
            Console.WriteLine(p);
            Console.WriteLine(DistanceCalculator.CalculateDistance(p,q));
            List<Point3D> path = new List<Point3D>();
            path.Add(p);
            path.Add(q);
            Paths newPath = new Paths(path);
            Storage.LoadPoints();
            
        }
    }
}
