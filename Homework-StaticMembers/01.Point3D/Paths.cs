using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
   public class Paths
    {
        private List<Point3D> sequencePoints;
        public List<Point3D> SequencePoints
        {
            get { return this.sequencePoints; }
            set
            {
                if(value.Count<1)
                {
                    throw new ArgumentException("Empty List");
                }
                else
                {
                    this.sequencePoints = value;
                }
            }
        }
        public Paths(List<Point3D> sequencePoints)
        {
            this.SequencePoints = sequencePoints;
            Storage.SavePoints(this.SequencePoints);
        }
    }
}
