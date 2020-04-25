using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HP { get; set; }

            public Vehicle(string type, string model, string color, int horse)
            {
                Type = type;
                Model = model;
                Color = color;
                HP = horse;
            }
            public override string ToString()
            {
                string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                    $"Model: {this.Model}{Environment.NewLine}" +
                                    $"Color: {this.Color}{Environment.NewLine}" +
                                    $"Horsepower: {this.HP}";

                return vehicleStr;
            }

        };

        static void Main(string[] args)
        {
            var Cataloge = new List<Vehicle>();


            string comand = string.Empty;
            while ((comand = Console.ReadLine()) != "End")
            {
                var ComSp = comand.Split(" ").ToArray();

                var curTruck = new Vehicle(ComSp[0], ComSp[1], ComSp[2], int.Parse(ComSp[3]));
                Cataloge.Add(curTruck);

            }

            string SecComand = string.Empty;
            while ((SecComand = Console.ReadLine()) != "Close the Catalogue")
            {

                Console.WriteLine(Cataloge.Find(x => x.Model == SecComand));

            }

            var onlyCars = Cataloge.Where(x => x.Type == "car").ToList();
            var onlyTrucks = Cataloge.Where(x => x.Type == "truck").ToList();
            double totalCarsHorsepower = 0;
            double totalTrucksHorsepower = 0;

            foreach (var car in onlyCars)
            {
                totalCarsHorsepower += car.HP;
            }

            foreach (var truck in onlyTrucks)
            {
                totalTrucksHorsepower += truck.HP;
            }

            double averageCarsHorsepower = totalCarsHorsepower / onlyCars.Count;
            double averageTrucksHorsepower = totalTrucksHorsepower / onlyTrucks.Count;
            if (averageCarsHorsepower > 0 && averageTrucksHorsepower > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
            else if (averageCarsHorsepower > 0 && averageTrucksHorsepower <= 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
            }
            else if (averageCarsHorsepower <= 0 && averageTrucksHorsepower > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
        }
    }
}
