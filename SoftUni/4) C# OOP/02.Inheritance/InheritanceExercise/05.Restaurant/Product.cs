namespace _05.Restaurant
{
    public abstract class Product
    {
        private string _name;
        private decimal _price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get => _name;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null");
                }

                _name = value;
            }
        }

        public decimal Price 
        {
            get => _price;
            private set
            {
                if (_price <= 0)
                {
                    throw new ArgumentException("Price cannot be 0");
                }

                _price = value;
            }
        }
    }
}