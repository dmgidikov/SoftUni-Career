using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Exceptions;
using Vehicles.Models.Contracts;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDravable, IRefuelable
    {
        private double fuelQuantity;
        private double fuelConsumption;
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }

        public virtual double FuelConsumption
        {
            get => this.FuelConsumption;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.fuelConsumptionException);
                }

                this.FuelConsumption = value;
            }
        }

        public string Drive(double distance)
        {
            var neededFuel = distance * this.FuelConsumption;

            if (neededFuel > this.FuelQuantity)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.fuelConsumptionException,
                        this.GetType().Name));
            }

            this.FuelQuantity -= neededFuel;

            return $"{this.GetType().Name} travelled {distance} km";

        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount > 0)
            {

            }
        }
    }
}
