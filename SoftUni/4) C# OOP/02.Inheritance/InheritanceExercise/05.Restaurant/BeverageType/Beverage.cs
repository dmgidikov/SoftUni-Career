namespace _05.Restaurant.BeverageType
{
    public abstract class Beverage : Product
    {
        private double _milliliters;

        public Beverage(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            this.Milliliters = milliliters;
        }

        public double Milliliters
        {
            get => _milliliters;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Milliliters cannot be less than or 0");
                }

                _milliliters = value;
            }
        }
    }
}