namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;

        public Tesla(string model,string color,int battery)
        {
            this.Model = model;
            this.Color = color;
            this.Batteryy = battery;
        }
        public string Model { get; set; }
        public string Color { get; set; }

        public int Batteryy { get; set; }
        public int Battery()
        {
            return 2;
        }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaak!";
        }
        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery()} Batteries\n{Start()}\n{Stop()}";
        }
    }
}
