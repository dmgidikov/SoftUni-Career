namespace BlackFriday.Models
{
    public class Service : Product
    {
        private const double DefaultDiscount = 0.2;

        public Service(string productName, double basePrice) 
            : base(productName, basePrice)
        {
        }

        public override double BlackFridayPrice => DefaultDiscount * BasePrice;
    }
}