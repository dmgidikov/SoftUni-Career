namespace ProductShop.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public int Id { get; set; }

        [MinLength(3)]
        public string? Name { get; set; }

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}