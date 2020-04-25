namespace P01_RawData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Runner
    {
        public void Run()
        {

        List<Car> cars = new List<Car>();

        int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i<lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string model = parameters[0];

        int engineSpeed = int.Parse(parameters[1]);
        int enginePower = int.Parse(parameters[2]);
        int cargoWeight = int.Parse(parameters[3]);
        string cargoType = parameters[4];

        Tire[] tire1 = new Tire[4];

        double tire1Pressure = double.Parse(parameters[5]);
        int tire1age = int.Parse(parameters[6]);
        tire1[0] = new Tire(tire1age, tire1Pressure);

        double tire2Pressure = double.Parse(parameters[7]);
        int tire2age = int.Parse(parameters[8]);
        tire1[1] = new Tire(tire2age, tire2Pressure);

        double tire3Pressure = double.Parse(parameters[9]);
        int tire3age = int.Parse(parameters[10]);
        tire1[2] = new Tire(tire3age, tire3Pressure);

        double tire4Pressure = double.Parse(parameters[11]);
        int tire4age = int.Parse(parameters[12]);
        tire1[3] = new Tire(tire4age, tire4Pressure);


        Engine engine1 = new Engine(engineSpeed, enginePower);
        Cargo cargo1 = new Cargo(cargoWeight, cargoType);
        cars.Add(new Car(model, engine1, cargo1, tire1));
            }
    string command = Console.ReadLine();
                if (command == "fragile")
                {
                    List<string> fragile = cars
                        .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                        .Select(x => x.Model)
                        .ToList();

    Console.WriteLine(string.Join(Environment.NewLine, fragile));
                }
                else
                {
                    List<string> flamable = cars
                        .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                        .Select(x => x.Model)
                        .ToList();

Console.WriteLine(string.Join(Environment.NewLine, flamable));
                }
         }
    }
}
