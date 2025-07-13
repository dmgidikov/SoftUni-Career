namespace ShopHierarchy
{
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int SalesmanId { get; set; }
        public SalesMan SalesMan { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
