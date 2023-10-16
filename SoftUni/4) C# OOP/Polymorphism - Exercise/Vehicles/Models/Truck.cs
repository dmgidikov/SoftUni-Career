using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double AIR_CONDITION_CONSUMPTION = 1.6;
        private const double REFUEL = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption)
        {

        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value + AIR_CONDITION_CONSUMPTION;
        }

        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * REFUEL);
        }
    }
}
