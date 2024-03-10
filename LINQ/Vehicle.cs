using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public abstract class Vehicle
    {
        public string? Name { get; set; }
        public string? Manufacturer { get; set; }
        public int YearOfManufacture { get; set; }
        public double Price { get; set; }

        protected Vehicle(string? name, string? manufacturer, int yearOfManufacture, double price)
        {
            Name = name;
            Manufacturer = manufacturer;
            YearOfManufacture = yearOfManufacture;
            Price = price;
        }

        public abstract void PrintToConsole();
    }
}
