namespace VehiclesMine
{
    using System;
   public abstract class Vehicle
    {
        public  Vehicle(double fuelQuantity,double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;

            if(fuelQuantity>tankCapacity)
            {
                fuelQuantity = 0;
            }
            else
            {
                this.FuelQuantity = fuelQuantity;
            }
            this.FuelConsumption = fuelConsumption;
        }
        public double TankCapacity { get; set; }
        
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public virtual double AirConditon { get; }

        public string DriveBody(double consuption, double value)
        {
            if (consuption <= FuelQuantity)
            {
                FuelQuantity -= consuption;
                return $"{GetType().Name} travelled {value} km";
            }
            return $"{GetType().Name} needs refueling";
        }
        public  string DriveEmpty(double value)
        {
            var consuption = (FuelConsumption) * value;
           return DriveBody(consuption,value);
        }
        public  string Drive(double value)
        {
            var consuption = (AirConditon+FuelConsumption) * value;
            return DriveBody(consuption,value);
        }
       
        public virtual  void Refuel(double liters)
        {
            if(liters<=0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
            if (liters+FuelQuantity>TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantity:f2}";
        }

    }
}
