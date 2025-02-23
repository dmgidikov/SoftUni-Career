namespace BlackFriday.Models
{
    public class Item : Product
    {
        private const double DefaultDiscount = 0.3;

        public Item(string productName, double basePrice) 
            : base(productName, basePrice)
        {            
        }

        public override double BlackFridayPrice => DefaultDiscount * BasePrice;
    }
}