using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();
            catalog.trucks = new List<Truck>();
            catalog.cars = new List<Car>();
            while (true)
            {
                List<string> data = Console.ReadLine().Split("/").ToList();
                if (data[0] == "end") break;

                else if (data[0] == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = data[1];
                    truck.Model = data[2];
                    truck.Weight = data[3];
                    catalog.trucks.Add(truck);
                }
                else if (data[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = data[1];
                    car.Model = data[2];
                    car.HorsePower = data[3];
                    catalog.cars.Add(car);
                }
            }

            if (catalog.cars.Count > 0)
            {
               // foreach (var car in catalog.cars.OrderBy(c => c.Brand))
                    catalog.cars.Sort((x, y) => string.Compare(x.Brand, y.Brand));
                    Console.WriteLine("Cars:");
                foreach (var car in catalog.cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.trucks.Count > 0)
            {
                //foreach (var truck in catalog.trucks.OrderBy(t => t.Brand))
                    catalog.trucks.Sort((x, y) => string.Compare(x.Brand, y.Brand));
                    Console.WriteLine("Trucks:");
                foreach (var truck in catalog.trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }


    public class Truck
    {
        public string Brand;
        public string Model;
        public string Weight;
    }
    public class Car
    {
        public string Brand;
        public string Model;
        public string HorsePower;
    }
    public class Catalog
    {
        public List<Truck> trucks;
        public List<Car> cars;

    }
}