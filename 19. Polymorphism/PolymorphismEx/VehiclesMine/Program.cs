namespace VehiclesMine
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Vehicle car = new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle truck = new Truck(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Vehicle bus = new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));

            int nummber = int.Parse(Console.ReadLine());

            for (int i = 0; i < nummber; i++)
            {
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = input[1];
                string comand = input[0];
                double value = double.Parse(input[2]);
                

                switch (type)
                {
                    case "Bus":
                        {
                            ComandCheck(bus, comand, value);
                            break;
                        }
                    case "Car":
                        {
                            ComandCheck(car, comand, value);
                            break;
                        }
                    case "Truck":
                        {
                            ComandCheck(truck, comand, value);
                            break;
                        }


                    default:
                        break;
                }

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
        private static void ComandCheck(Vehicle vehicle, string command, double value)
        {
            switch (command)
            {
                case "Drive":
                    {
                        Console.WriteLine(vehicle.Drive(value));
                        break;
                    }
                case "DriveEmpty":
                    {
                        Console.WriteLine(vehicle.DriveEmpty(value));
                        break;
                    }
                case "Refuel":
                    try
                    {
                        vehicle.Refuel(value);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
              
            }

        }
        
    }
}
