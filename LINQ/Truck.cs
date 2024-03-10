using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Truck : Vehicle
    {
        public string? OwnerCompany { get; set; }

        public Truck(string? name, string? companyOwner, string? manufacturer, int yearOfManufacture, double price) : base(name, manufacturer, yearOfManufacture, price)
        {
            OwnerCompany = companyOwner;
        }

        public override void PrintToConsole()
        {
            Console.WriteLine($"{Name} | CompanyOwner: {OwnerCompany} | Manufacturer: {Manufacturer} | YearOfManufacture: {YearOfManufacture} | Price: {Price}");
        }
    }
}
