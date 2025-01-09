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
        public string Color { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        
        public Car ()
        {
            Brand = "Unknown";
            Model = "Unknown";
            Year = 0;
            Color = "Unknown";
            Price = 0.0m;
        }

        public Car (string a, string b, decimal c, string d, int e)
        {
            Brand = a;
            Model = b;
            Price = c;
            Color = d;
            Year = e;
        }

        override public string ToString()
        {
            return Brand + " " + Model + " " + Color + " " + Year + " " + Price + "$";
        }
    }
}
