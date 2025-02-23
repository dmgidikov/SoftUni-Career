namespace BlackFriday.Models
{
    using Contracts;
    using Utilities.Messages;

    public abstract class Product : IProduct
    {
        private string _productName;
        private double _basePrice;

        protected Product(string productName, double basePrice)
        {
            ProductName = productName;
            BasePrice = basePrice;
            IsSold = false;
        }

        public string ProductName
        {
            get => _productName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.ProductNameRequired);
                }

                _productName = value;
            }
        }

        public double BasePrice
        {
            get => _basePrice;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.ProductPriceConstraints);
                }

                _basePrice = value;
            }
        }

        public virtual double BlackFridayPrice { get; protected set; }

        public bool IsSold { get; private set; }

        public void UpdatePrice(double newPriceValue) => _basePrice = newPriceValue;

        public void ToggleStatus()
        {
            if (IsSold)
            {
                IsSold = false;
            }
            else if (IsSold == false)
            {
                IsSold = true;
            }
        }

        public override string ToString()
        {
            return $"Product: {ProductName}, Price: {BasePrice:F2}, You Save: {(BasePrice - BlackFridayPrice):F2}";
        }
    }
}