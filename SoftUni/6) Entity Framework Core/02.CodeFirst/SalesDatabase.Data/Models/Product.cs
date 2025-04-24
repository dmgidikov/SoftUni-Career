namespace SalesDatabase.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double  Quantity { get; set; }

        public decimal Price { get; set; }

        public ICollection<Sale> Sales = new HashSet<Sale>();
    }
}