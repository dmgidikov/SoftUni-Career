using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Product
    {
        private string name;
        private decimal price;

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;

        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public decimal Price
        {
            get => this.price;
            set => this.price = value;
        }
    }
}
