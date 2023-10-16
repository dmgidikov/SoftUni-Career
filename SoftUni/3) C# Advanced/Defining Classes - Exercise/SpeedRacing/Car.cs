using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double travelledDistance;

        public Car()
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.TravelledDistance = 0;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public double FuelAmount
        {
            get => fuelAmount;
            set => fuelAmount = value;
        }

        public double FuelConsumption
        {
            get => fuelConsumption;
            set => fuelConsumption = value;
        }

        public double TravelledDistance
        {
            get => travelledDistance;
            set => travelledDistance = value;
        }

        public void Drive(string model, double distance)
        {
            var neededFuel = fuelConsumption * distance;

            if (neededFuel <= fuelAmount)
            {
                fuelAmount -= neededFuel;
                travelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.model} {this.fuelAmount:f2} {this.travelledDistance}";
        }
    }
}
