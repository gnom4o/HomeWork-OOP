using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        Laptop l1 = new Laptop("HP 250 G2", "HP", "Li-on, 2 cell", "3 hours", "3,2 GhZ", "8 GB", "Onboard", " 1 TB Hitachi", "13\"IPS", 699);
        Laptop l2 = new Laptop("Lenovo E82", 2999.99);
        Laptop l3 = new Laptop("AlienWare 8320", "Dell", "Li-ON,4 cell", "4,5 hours", "4,5 GHz", "16 GB 1866 MhZ", "Gigabyte 280x ATI RADEON", "SSD 240 GB + 3 TB mechanical Seagate Baracuda", "IPS", 8500);
        
        Console.WriteLine(l1);
        Console.WriteLine(l2);
        Console.WriteLine(l3);
    }
}

