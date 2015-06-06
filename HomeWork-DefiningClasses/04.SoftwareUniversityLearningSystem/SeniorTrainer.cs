using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string name,string lastname,int age): base(name,lastname,age)
        {

        }
        public void DeleteCourse(string courseName)
        {
            Console.WriteLine("Course {0} has been deleted successfully",courseName);
        }
    }
}
