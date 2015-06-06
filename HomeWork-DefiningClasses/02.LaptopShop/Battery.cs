using System;
using System.Collections.Generic;
using System.Linq;

    class Battery
    {
        private string type;
        
        private string batteryLife;

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.type = value;
                }
                else
                {
                    this.type = "Not Specified";
                }
            }
            
        }
    
        
        public string BatteryLife 
        { 
            get
            {
                return this.batteryLife;
            }
            set
            {
                if  (!string.IsNullOrWhiteSpace(value) || !string.IsNullOrEmpty(value))
                {
                    this.batteryLife = value;
                }
                else
                {
                    this.batteryLife = "Not Specified";
                }
            }
        }
        public Battery(string type,string batteryLife)
        {
            this.BatteryLife = batteryLife;
           
            this.Type = type;
        }
        public Battery():this(null,null)
        {
           
        }
    }

