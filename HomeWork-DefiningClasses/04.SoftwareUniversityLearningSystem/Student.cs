using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class Student : Person
    {
        public string studentId { get; set; }
        public double averegeGrade { get; set; }
        public Student(string name,string lastname,int age): base(name,lastname,age)
        {

        }
        public Student(string studentId,double averegaeGrade)
        {
            this.studentId = studentId;
            this.averegeGrade = averegeGrade;
        }
        
    }
}
