using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class OnsiteStudent :CurrentStudent
    {
        public OnsiteStudent(string name,string lastname,int age,string studentId,double averegeGrade,string currentCourse): base(name,lastname,age,studentId,averegeGrade,currentCourse)
        {

        }
    }
}
