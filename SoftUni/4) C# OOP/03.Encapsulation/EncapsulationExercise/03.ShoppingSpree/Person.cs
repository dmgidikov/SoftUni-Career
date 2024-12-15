namespace ShoppingSpree
{
    public class Person
    {
        private string _name;
        private decimal _money;
        private List<Product> _products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            _products = new List<Product>();
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

        public decimal Money
        {
            get => _money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Money cannot be negative");
                }

                _money = value;
            }
        }

        public IReadOnlyList<Product> products => _products;

        public string BuyProduct(Product product)
        {
            var output = string.Empty;

            if (product.Cost <= this.Money)
            {
                _products.Add(product);
                this.Money -= product.Cost;
                output += $"{this.Name} bought {product}";
            }
            else
                output += $"{this.Name} cant afford {product}";

            return output ;
        }
    }
}