namespace _05.Restaurant.BeverageType.HotBeverage
{
    public abstract class HotBeverange : Beverage
    {
        public HotBeverange(string name, decimal price, double milliliters)
            : base(name, price, milliliters)
        {
        }
    }
}