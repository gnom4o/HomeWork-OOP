using System;
using System.Collections.Generic;
using System.Linq;


class Persons
{
    static void Main()
    {
        Person p1 = new Person("Gosho", 22);
        Console.WriteLine(p1);
        Person p2 = new Person("Pesho", 100, "bla@bla");
        Console.WriteLine(p2);
    }
}

