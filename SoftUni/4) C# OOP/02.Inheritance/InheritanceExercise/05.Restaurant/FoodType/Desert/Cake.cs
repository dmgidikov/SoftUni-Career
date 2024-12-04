namespace _05.Restaurant.FoodType.Desert
{
    public abstract class Cake : Desert
    {
        public Cake(string name, decimal price, double grams, double calories)
            : base(name, price, grams, calories)
        {
        }
    }
}