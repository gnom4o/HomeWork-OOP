using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class CurrentStudent: Student
    {
        public string CurrentCourse { get; set; }
        public CurrentStudent(string name,string lastname,int age,string studentId,double averegeGrade,string currentCourse): base(name,lastname,age,studentId,averegeGrade)
        {
            this.CurrentCourse = currentCourse;
        }
        public override string ToString()
        {
            return base.ToString()+ string.Format("Current Course: {0}",this.CurrentCourse);
        }
    }
}
