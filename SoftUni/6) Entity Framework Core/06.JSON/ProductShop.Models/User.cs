namespace ProductShop.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int Id { get; set; } 

        public string? FirstName { get; set; }
        
        [MinLength(3)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        public ICollection<Product> ProductsSold { get; set; } = new HashSet<Product>();

        public ICollection<Product> ProductsBought { get; set; } = new HashSet<Product>();
    }
}