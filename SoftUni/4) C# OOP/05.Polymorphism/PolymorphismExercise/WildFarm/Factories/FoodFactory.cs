namespace WildFarm.Factories
{
    using Models.Foods;
    using Models.Foods.Contracts;

    public class FoodFactory
    {
        public IFood ProduceFood(string type, int quantity)
        {
            IFood food = null;

            food = type switch
            {
                "Vegetable" => new Vegetable(quantity),
                "Fruit" => new Fruit(quantity),
                "Meat" => new Meat(quantity),
                "Seeds" => new Seeds(quantity),
            };

            return food;
        }
    }
}