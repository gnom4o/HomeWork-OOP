using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class Student : Person
    {
        public double AveregeGrade { get; set; }
        public string StudentId { get; set; }
        
        public Student(string name, string lastname, int age, string studentId, double averegeGrade) : base(name, lastname, age)
        {
            this.StudentId = studentId;
            this.AveregeGrade = averegeGrade;
        }

        public override string ToString()
        {
            return base.ToString()+ string.Format("Id: {0},\nAverege Grade: {1},\n",this.StudentId,this.AveregeGrade);
        }
    }
}
