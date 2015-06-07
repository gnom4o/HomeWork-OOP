using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class SoftwareUniversityLearningSystem
    {
        static void Main()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Georgi", "Georgiev", 23));
            persons.Add(new Trainer("Dimitar","Dimitrov",35));
            persons.Add(new JuniorTrainer("Gencho","Genchev",45));
            persons.Add(new SeniorTrainer("Petko", "Petkov", 32));
            persons.Add(new Student("Vladislav", "Spasov", 35,"231113",4.5));
            persons.Add(new OnlineStudent("Ginka", "Ginkova", 25, "331233", 5.5,"OOP",4));
            persons.Add(new OnsiteStudent("Penka", "Penkova", 23, "123366", 3.5, "OOP"));
            persons.Add(new DropoutStudent("Stoqn", "Stoqnov", 44, "213391", 5.2, "Neplatil"));
            persons.Add(new CurrentStudent("Dinko", "Dinkov", 21, "351235", 3.3, "OOP"));
            persons.Add(new GraduadeStudent("Todor", "Todorov", 27, "120964", 6));

            foreach (var item in persons.Where(p =>p is CurrentStudent).OrderBy(p => ((Student)p).AveregeGrade))
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}
