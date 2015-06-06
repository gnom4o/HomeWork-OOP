using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Person
{

    private string name;      
    private int age;
    private string email; 

    public string Name
    {
        get { return this.name; }
        set
        {
            if(!string.IsNullOrEmpty(value))
            {
                this.name = value;
            }
            else
            {
                throw new ArgumentException("Empty or missing name");
            }
        }
    }
    public string Email
    {
        get { return this.email; }
        set
        {
            Regex reg = new Regex(@".*@.*");
           if(value==null)
           {
               this.email = "No Email Entered";
           }
           else if(reg.IsMatch(value))
           {
               this.email = value;
           }
           else
           {
               throw new ArgumentException("Invalid Email");
           }
        }
    }
        
    public int Age
    {
        get { return this.age; }
        set
        {
            if(value >=1 && value <=100)
            {
                this.age = value;
            }
            else
            {
                throw new ArgumentException("Invalid Age");
            }
        }

    }
    
    
    public Person(string name,int age ,string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    public Person(string name,int age): this(name,age,null)
    {

    }
    public override string ToString()
    {
        return String.Format("Name:{0}\nAge:{1}\nEmail:{2}", this.name, this.age, this.email);
    }
}

