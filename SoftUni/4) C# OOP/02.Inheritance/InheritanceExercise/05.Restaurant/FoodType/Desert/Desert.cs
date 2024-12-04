namespace _05.Restaurant.FoodType.Desert
{
    public abstract class Desert : Food
    {
        private double _calories;

        public Desert(string name, decimal price, double grams, double calories)
            : base(name, price, grams)
        {
            Calories = calories;
        }
        public double Calories
        {
            get => _calories;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Callories cannot be less than 0");
                }

                _calories = value;
            }
        }
    }
}