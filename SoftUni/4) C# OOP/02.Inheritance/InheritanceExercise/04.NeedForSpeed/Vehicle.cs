namespace _04.NeedForSpeed
{
    public class Vehicle
    {
        private int _horsePower;
        private double _fuel;

        public Vehicle(int horsePower, double fuel)
        {
            this._horsePower = horsePower;
            this._fuel = fuel;
            this.DefaultFuelConsumption = 1.25;
        }

        public int HorsePower => this._horsePower;

        public double Fuel => this._fuel;

        protected double DefaultFuelConsumption {  get; set; }

        public virtual double FuelConsumption { get; set; }

        public virtual void Drive(double kilometers)
        {
            var needFuel = kilometers * DefaultFuelConsumption / 100;
            this._fuel -= needFuel;
        }
    }
}