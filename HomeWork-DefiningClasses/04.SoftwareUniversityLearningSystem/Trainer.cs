using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class Trainer : Person
    {
        public Trainer(string name,string lastname,int age): base(name,lastname,age)
        {

        }
        public void CreateCourse(string courseName)
        {
            Console.WriteLine("Course {0} has been created successfully!",courseName);
        }
    }
}
