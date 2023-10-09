using ShoppingSpree.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree.Models
{
    public class Person
    {
        private const decimal MONEY_MIN_VALUE = 0;

        private string name;
        private decimal money;
        private List<Product> bag;

        private Person()
        {
            bag = new List<Product>();
        }

        public Person(string name, decimal money)
            : this()
        {
            Name = name;
            Money = money;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameMessage);
                }

                name = value;
            }
        }

        public decimal Money
        {
            get => money;
            private set
            {
                if (value < MONEY_MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMoneyMessage);
                }

                money = value;
            }
        }

        public IReadOnlyList<Product> Bag
        {
            get => this.bag;
        }

        public void BuyProduct(Product product)
        {
            if (this.money < product.Cost)
            {
                throw new InvalidOperationException(string.Format
                    (GlobalConstants.InvalidBuyProductMessage, this.Name, product.Name));
            }

            this.money -= product.Cost;
            this.bag.Add(product);
        }

        public override string ToString()
        {
            var productsOutput = this.bag.Count > 0 ?
                string.Join(", ", this.Bag)
                : "'Nothing bought";

            return $"{this.Name} - {productsOutput}";
        }
    }
}
