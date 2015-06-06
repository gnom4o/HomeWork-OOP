using System;
using System.Collections.Generic;
using System.Linq;

    class Component
    {
        private string name;
        private string details;
        private double price;
        public Component(string name,double price): this(name,null,price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Component(string name,string detail,double price)
        {
            this.name = name;
            this.Price = price;
            this.Details = details;
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("Price could not be negative number");
                }
                else
                {
                    this.price = value;
                }
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Please provide name");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (string.Empty==value)
                {
                    throw new ArgumentException("Please provide details");
                }
                else
                {
                    this.details = value;
                }
            }
        }

    }

