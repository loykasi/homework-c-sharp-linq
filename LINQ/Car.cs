using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Car : Vehicle
    {
        public Car(string? name, string? manufacturer, int yearOfManufacture, double price) : base(name, manufacturer, yearOfManufacture, price)
        {
        }

        public override void PrintToConsole()
        {
            Console.WriteLine($"{Name} | Manufacturer: {Manufacturer} | YearOfManufacture: {YearOfManufacture} | Price: {Price}");
        }
    }
}
