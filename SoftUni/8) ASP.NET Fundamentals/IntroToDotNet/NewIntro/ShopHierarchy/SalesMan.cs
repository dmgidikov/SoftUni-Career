namespace ShopHierarchy
{
    using System.ComponentModel.DataAnnotations;

    public class SalesMan
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
