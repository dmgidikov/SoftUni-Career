namespace _04.PizzaCalories
{
    using Ingredients;

    public class Pizza
    {
        private string _name;
        private Dough _dough;
        private List<Topping> _toppings;

        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            this.Name = name;
            _dough = dough;
            _toppings = _toppings;
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (value.Length < Constants.Contstant.PIZZA_NAME_MIN_LENGTH ||
                    value.Length > Constants.Contstant.PIZZA_NAME_MAX_LENGTH)
                {
                    throw new ArgumentException(Exceptions.Exception.PizzaNameExeption);
                }

                _name = value;
            }
        }

        public IReadOnlyList<Topping> Toppings => _toppings;

        public override string ToString()
        {
            var doughCalories = _dough.GetCalories();
            var toppingCalories = 0d;

            foreach (var topping in _toppings)
            {
                var tempCalories = topping.GetCalories();
                toppingCalories += tempCalories;
            }

            var totalCalories = doughCalories + toppingCalories;
            return $"{this.Name} - {totalCalories:f2} Calories.";
        }
    }
}