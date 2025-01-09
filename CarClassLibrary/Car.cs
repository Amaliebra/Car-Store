using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        
        public Car ()
        {
            Brand = "Unknown";
            Model = "Unknown";
            Price = 0.0m;
        }

        public Car (string a, string b, decimal c)
        {
            Brand = a;
            Model = b;
            Price = c;
        }
    }
}
