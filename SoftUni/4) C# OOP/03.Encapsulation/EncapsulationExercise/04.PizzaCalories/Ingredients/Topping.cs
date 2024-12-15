namespace _04.PizzaCalories.Ingredients
{
    public class Topping 
    {
        private string _type;
        private double _weight;

        private Dictionary<string, double> toppings = new Dictionary<string, double>
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce" , 0.9 }
        };

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.GetCalories();
        }

        public string Type
        {
            get => _type;
            private set
            {
                if (toppings.ContainsKey(value) == false)
                {
                    throw new ArgumentException(string.Format
                        (Exceptions.Exception.ToppingInproperTypeExeption, value));
                }

                _type = value;
            }
        }

        public double Weight
        {
            get => _weight;
            private set
            {
                if (value < Constants.Contstant.WEIGHT_MIN_VALUE ||
                    value > Constants.Contstant.TOPPING_WEIGHT_MAX_VALUE)
                {
                    throw new ArgumentException(string.Format
                        (Exceptions.Exception.ToppingWeightExeption, this.Type));
                }

                _weight = value;
            }
        }

        public double GetCalories()
        {
            var modifier = 1 * toppings[Type];
            var calories = 2 * modifier * _weight;

            return calories;
        }
    }
}