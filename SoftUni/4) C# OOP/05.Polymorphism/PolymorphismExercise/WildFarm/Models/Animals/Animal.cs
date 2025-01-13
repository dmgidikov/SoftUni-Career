namespace WildFarm.Models.Animals
{
    using Contracts;
    using Exceptions;
    using Foods.Contracts;

    public abstract class Animal : IAnimal
    {
        private const string WrongFoodMessage =
            "{0} does not eat {1}!";

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; protected set; }

        public double Weight { get; protected set; }

        public int FoodEatern { get; protected set; }

        public abstract double WeightMultiplier { get; }

        public abstract ICollection<Type> PrefferedFoods { get; }

        public void Feed(IFood food)
        {
            if (this.PrefferedFoods.Contains(food.GetType()) == false)
            {
                throw new WrongFoodException(String.Format(WrongFoodMessage,
                    this.GetType().Name, food.GetType().Name));
            }

            this.Weight += this.WeightMultiplier * food.Quantity;
            this.FoodEatern += food.Quantity;
        }

        public abstract string ProduceSound();
    }
}