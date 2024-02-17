using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ShopHierarchy
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        public ICollection<OrderItem> Orders { get; set; } = new List<OrderItem>();
    }
}
