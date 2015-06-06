using System;
using System.Collections.Generic;
using System.Linq;

class Laptop
{
    private string model;
    private string manufacture;
    private string battery;
    private string batteryLife;
    private string processor;
    private string ram;
    private string graphicCard;
    private string hdd;
    private string screen;
    private double price;
    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid Model");
            }
            else
            {
                this.model = value;
            }
        }

    }
    public double Price
    {
        get { return this.price; }
        set
        {
            if(value >=0)
            {
                this.price = value;
            }
            else
            {
                throw new ArgumentException("Price cannot be negative number");
            }
        }
    }
    public string Manufacture
    {
        get
        {
            return this.manufacture;
        }
        set 
        {
          if (string.Empty!=value)
	        {
                this.manufacture = value;		 
	        }
          else
          {
              throw new ArgumentException("Invalid string");
          }
           
        }
    }
    public string Processor {
        get
        {
            return this.processor;
        }
        set
        {
            if (string.Empty!=value)
            {
                this.processor = value;
            }
            else
            {
                throw new ArgumentException("Invalid string");
            }
            
        }
    }
    public string Ram
    {
        get
        { return this.ram;}
        set
        {
            {
                if (string.Empty!=value)
                {
                    this.ram = value;
                }
                else
                {
                    throw new ArgumentException("Invalid string");
                }
            }
        }
    }
    public string Hdd
    {
        get { return this.ram; }
        set
        {
            if(string.Empty!=value)
            {
                this.hdd = value;
            }
            else
            {
                throw new ArgumentException("Invalid string");
            }
        }
    }
    public string Screen
    {
        get { return this.screen; }
        set 
        {
            if(string.Empty!=value)
            {
                this.screen = value;
            }
            else
            {
                throw new ArgumentException("Invalid string");
            }
        }
    }

    public Laptop(string model,string manufacture,string battery,string batteryLife,string processor,string ram,string graphicCard,string hdd,string screen, double price)
    {
      this.Model=model;
      this.Manufacture = manufacture;
      this.Processor = processor;
      this.Ram = ram;
      Battery bat = new Battery(battery, batteryLife);
      this.battery = bat.Type;
      this.graphicCard = graphicCard;
      this.Hdd = hdd;
      this.batteryLife= bat.BatteryLife;
      this.Screen = screen;
      this.Price = price;
    }
  
        
    public Laptop(string model , double price): this(model,null,null,null,null,null,null,null,null,price)
    {

    }

    public override string ToString()
    {
       if(this.manufacture!=null)
       {
      return String.Format("Model | {0}\nManufacture | {1}\nProcessor | {2}\nRAM | {3}\ngraphic card | {4}\nHDD | {5}\nscreen | {6}\nbattery | {7}\nbattery life | {8}\nPrice | {9} lv\n", this.model, this.manufacture, this.processor, this.ram,
      this.graphicCard, this.hdd, this.screen, this.battery, this.batteryLife, this.price);
       }
       else
       {
           return String.Format("Model | {0}\nPrice | {1} lv\n", this.model, this.price);
       }
      
        
        
    }

   
}

