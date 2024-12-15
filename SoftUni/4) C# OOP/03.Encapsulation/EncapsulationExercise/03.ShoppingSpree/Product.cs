namespace ShoppingSpree
{
    public class Product
    {
        private string _name;
        private decimal _cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null");
                }

                _name = value;
            }
        }

        public decimal Cost
        {
            get => _cost;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Product must have a price");
                }

                _cost = value;
            }
        }
    }
}