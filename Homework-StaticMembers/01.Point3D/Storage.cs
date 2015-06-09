using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public static class Storage
    {
        public static void LoadPoints()
        {
            string line;
            using(StreamReader reader = new StreamReader(@"../../paths.txt"))
            {
               line = reader.ReadToEnd();
               
            }
            Console.WriteLine(line);
        }
        public static void SavePoints(List<Point3D> points)
        {
            using (StreamWriter writer = new StreamWriter("../../paths.txt"))
            {
                foreach (var point in points)
                {
                    writer.WriteLine("X: "+point.X + " " +"Y: "+ point.Y + " " + "Z: "+point.Z + " ");
                }               
            }

        }
        }
    }

