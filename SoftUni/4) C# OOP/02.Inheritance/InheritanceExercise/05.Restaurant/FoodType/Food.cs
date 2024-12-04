namespace _05.Restaurant.FoodType
{
    public abstract class Food : Product
    {
        private double _grams;

        public Food(string name, decimal price, double grams)
            : base(name, price)
        {
            this.Grams = grams;
        }

        public double Grams
        {
            get => _grams;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Grams cannot be 0");
                }

                _grams = value;
            }
        }
    }
}