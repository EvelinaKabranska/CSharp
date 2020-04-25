using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesMine
{
   public class Bus : Vehicle
    {
        private const double air = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override double AirConditon => air;
    }
}
