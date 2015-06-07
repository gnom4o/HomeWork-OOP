using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class DropoutStudent : Student
    {
        public string DropoutReason { get; set; }
        public DropoutStudent(string name, string lastname, int age, string studentId, double averegeGrade, string dropOutReason)
            : base(name, lastname, age, studentId,averegeGrade)
        {
            this.DropoutReason = dropOutReason;
        }
    }
}
