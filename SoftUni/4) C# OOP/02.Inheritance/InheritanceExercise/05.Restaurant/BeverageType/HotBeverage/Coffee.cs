namespace _05.Restaurant.BeverageType.HotBeverage
{
    public class Coffee : HotBeverange
    {
        private double _caffeine;

        public Coffee(string name, decimal price, double milliliters, double caffeine) 
            : base(name, price, milliliters)
        {

        }

        public double Caffeine
        {
            get => _caffeine;
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Caffeine cannot be less than 0");
                }

                _caffeine = value;
            }
        }
    }
}