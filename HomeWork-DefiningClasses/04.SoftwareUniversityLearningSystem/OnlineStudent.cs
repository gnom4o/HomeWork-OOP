using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class OnlineStudent : CurrentStudent
    {
        public int NumVistis { get; set; }
        public OnlineStudent(string name,string lastname,int age,string studentId,double averegeGrade,string currentCourse,int NumVisits): base(name,lastname,age,studentId,averegeGrade,currentCourse)
        {
            this.NumVistis = NumVistis;
        }
    }
}
