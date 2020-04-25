using System;
using System.Linq;
using System.Collections.Generic;
namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = string.Empty;
            var cars = new HashSet<string>();
            while ((comand = Console.ReadLine()) != "END")
            {
                string[] spComand = comand.Split(", ").ToArray();
                if (spComand[0] == "IN")
                {
                    string car = spComand[1];
                    cars.Add(car);
                }
                else if (spComand[0] == "OUT")
                {
                    string car = spComand[1];
                    cars.Remove(car);
                }
            }
            if (cars.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
           
        }
    }
}
