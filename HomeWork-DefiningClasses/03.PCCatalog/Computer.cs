using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

class Computer
{
    private string name;
    private List<Component> components;
    public double price;

    public Computer(string name,List<Component> components)
    {
        this.Name = name;
        this.Components = components;
        foreach (var item in components)
        {
            this.price += item.Price;
        }
        
        
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Please provide name");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public List<Component> Components
    {
        get { return this.components; }
        set
        {
            if(value.Count<=0)
            {
                throw new ArgumentException("Not components are provided");
            }
            else
            {
                this.components = value;
            }
        }
    }

    public override string ToString()
    {
        
        StringBuilder result = new StringBuilder();
        result.AppendFormat("Configuration : "+this.name+"\n");
        result.AppendFormat("Components:\n");
        foreach (var item in components)
	    {
		 result.AppendFormat(item.Name+": price => "+ item.Price+"lv\n");
	    }
        result.AppendFormat("Total Price: " + this.price+"lv\n");
        return result.ToString();
    }
}

