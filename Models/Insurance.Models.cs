using System;
using System.ComponentModel.DataAnnotations;

namespace Insurance.Models
{
     public class Carriers
    {
        public Carriers(string name, int value) {
            this.Name = name;
            this.Value = value;
        }

        [Required]
        public string Name { get; set; }        

        public int Value { get; set; }        
    }

}