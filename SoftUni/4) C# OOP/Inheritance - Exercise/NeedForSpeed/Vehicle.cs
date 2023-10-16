using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private int horsePower;
        private double fuel;
        private double fuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel) 
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower
        {
            get => this.horsePower;
            private set => this.horsePower = value;
        }

        public double Fuel
        {
            get => this.fuel;
            private set => this.fuel = value;
        }
        
        public double fuelConsumptions
        {
            get => this.fuelConsumption;
            set => this.fuelConsumption = value;
        }

        public virtual void Drive(double kilometers)
        {
            var neededFuel = fuelConsumption * kilometers;

            if (neededFuel > this.fuel)
            {
                throw new ArgumentException("Not enough fuel");
            }

            fuel -= neededFuel;
        }
       
        public override string ToString()
        {
            return $"{this.GetType().Name}, {fuel}";
        }
    }
}
