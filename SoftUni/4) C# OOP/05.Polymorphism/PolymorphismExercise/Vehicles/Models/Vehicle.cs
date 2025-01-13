namespace Vehicles.Models
{
    using Common;
    using Contracts;

    public abstract class Vehicle : IDriveable, IRefuelable
    {
        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; protected set; }

        public virtual double FuelConsumption { get; protected set; }       

        public string Drive(double kilometers)
        {
            double neededFuel = kilometers * this.FuelConsumption;

            if (this.FuelQuantity < neededFuel)
            {
                var excMsg = String.Format(ExceptionMessages
                    .NotEnoughFuelExceptionMessage, this.GetType().Name);

                throw new InvalidOperationException(excMsg);
            }

            this.FuelQuantity -= neededFuel;

            return $"{this.GetType().Name} travelled {kilometers} km";
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount > 0)
            {
                this.FuelQuantity += fuelAmount;
            }            
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity}";
        }
    }
}