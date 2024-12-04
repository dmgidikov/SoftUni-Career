namespace _05.Restaurant.FoodType.Main
{
    public abstract class MainDIsh : Food
    {
        protected MainDIsh(string name, decimal price, double grams)
            : base(name, price, grams)
        {

        }
    }
}