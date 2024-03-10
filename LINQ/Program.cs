namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car list");

            Car[] cars =
            {
                new Car("Toyota", "Toyota", 2002, 100000),
                new Car("Toyota1", "Toyota1", 2006, 250000),
                new Car("Toyota2", "Toyota2", 2015, 550000),
                new Car("Toyota3", "Toyota3", 2023, 1500000),
                new Car("Toyota4", "Toyota4", 2000, 100000)
            };

            Print(cars);

            var carsInPriceRange = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
            Console.WriteLine("\n1.1 Cars with price between 100.000 and 250.000:");
            Print(carsInPriceRange);

            var carsAfter1990 = cars.Where(car => car.YearOfManufacture > 1990);
            Console.WriteLine("\n1.2 Cars with year of manufacture after 1990:");
            Print(carsAfter1990);

            var manufacturerGroup = cars.GroupBy(car => car.Manufacturer)
                                                .Select(group => new
                                                {
                                                    Manufacturer = group.Key,
                                                    TotalValue = group.Sum(car => car.Price)
                                                });
            Console.WriteLine("\n1.3 Total price from each manufacturer:");
            foreach (var group in manufacturerGroup)
            {
                Console.WriteLine($"Manufacturer: {group.Manufacturer} | Total price: {group.TotalValue}");
            }

            Console.WriteLine("\n-------------------------------");

            Console.WriteLine("\nTruck list");

            Truck[] trucks =
            {
                new Truck("Toyota", "Jac", "Toyota", 2002, 100000),
                new Truck("Toyota1", "Jac", "Toyota1", 2006, 250000),
                new Truck("Toyota2", "3s", "Toyota2", 2015, 550000),
                new Truck("Toyota3", "3s", "Toyota3", 2023, 1500000),
                new Truck("Toyota4", "Jac", "Toyota4", 2000, 100000)
            };

            Print(trucks);

            Console.WriteLine("\n2.1 Sort by year:");
            var trucksOrderedByYear = trucks.OrderByDescending(truck => truck.YearOfManufacture);
            Print(trucksOrderedByYear);

            Console.WriteLine("\n2.2 All owner company:");
            var ownerCompanies = trucks.Select(truck => truck.OwnerCompany).Distinct();
            foreach (var owner in ownerCompanies)
            {
                Console.WriteLine(owner);
            }

            Console.WriteLine();
        }

        static void Print(IEnumerable<Vehicle> vehicles)
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.PrintToConsole();
            }
        }
    }
}