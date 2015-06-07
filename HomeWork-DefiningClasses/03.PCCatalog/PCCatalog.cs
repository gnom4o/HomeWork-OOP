using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PCCatalog
{
    class PCCatalog
    {
        static void Main()
        {
            List<Component> conf1 = new List<Component>();
            List<Computer> configurations = new List<Computer>();
            conf1.Add(new Component("AMD 8320", 350.89));
            conf1.Add(new Component("Corsair 8 GB RAM", 120));
            conf1.Add(new Component("Sapphire 280x",230));
            Computer comp1 = new Computer("AMD Powa", conf1);
            configurations.Add(comp1);

            List<Component> conf2 = new List<Component>();
            conf2.Add(new Component("Intel i7", 650.99));
            conf2.Add(new Component("Corsair 16 GB RAM", 240));
            conf2.Add(new Component("GTX 850", 280));
            conf2.Add(new Component("SSD Kingston 240GB",250.32));
            Computer comp2 = new Computer("Intel Powa",conf2);
            configurations.Add(comp2);

            List<Component> conf3 = new List<Component>();
            conf3.Add(new Component("Laptop cooler", 120));
            conf3.Add(new Component("Dell 27\"IPS matrix", 720));
            conf3.Add(new Component("Keyboard Logitech", 120));
            conf3.Add(new Component("SSD Kingston 240GB",250.32));
            Computer comp3 = new Computer("Alienware 8320",conf3);
            configurations.Add(comp3);
            
            foreach(var item in configurations.OrderBy(o=>o.price))
	        {
		       Console.WriteLine(item);
	        }
            
            
        }
    }
}
