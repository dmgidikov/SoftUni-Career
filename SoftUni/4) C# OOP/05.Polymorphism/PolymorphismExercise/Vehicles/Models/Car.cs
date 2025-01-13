namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double AIR_CONDITION_CONSUMPTION = 0.9;

        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {            
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value + AIR_CONDITION_CONSUMPTION;
        }
    }
}