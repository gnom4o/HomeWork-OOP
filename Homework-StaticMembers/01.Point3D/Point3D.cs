using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
   public class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int x,int y , int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        readonly static int[] startCoord={0,0,0};
        public static int[] StartCoord
        { get { return StartCoord; } }
        public override string ToString()
        {
            return string.Format("x={0},y={1},z={2}", this.X, this.Y, this.Z);
        }
    }
}
