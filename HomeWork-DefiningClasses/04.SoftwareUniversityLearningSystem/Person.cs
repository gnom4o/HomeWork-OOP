using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string name,string lastname,int age)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Age = age;
        }
    }
}
