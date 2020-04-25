namespace NeedForSpeed
{
   public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private const double defaultFuelConsumption = 1.25;
        private double fuelConsumption;


        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }
     
        public virtual double FuelConsumption
        
            => defaultFuelConsumption;

        public int HorsePower { get; set; }
        public double Fuel { get; set; }



        public virtual void Drive(double kilometers)
        {
            bool canDrive = this.Fuel - kilometers * this.FuelConsumption >= 0;
           if (canDrive)
            {
                this.Fuel -= kilometers * this.FuelConsumption;
            }

        }
    }
}
