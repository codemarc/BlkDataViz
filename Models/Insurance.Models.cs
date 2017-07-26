using System;

namespace Insurance.Models
{
     public class Carriers
    {
        public Carriers(string name, int value) {
            this.Name = name;
            this.Value = value;
        }
        public string Name { get; set; }        
        public int Value { get; set; }        
    }

}