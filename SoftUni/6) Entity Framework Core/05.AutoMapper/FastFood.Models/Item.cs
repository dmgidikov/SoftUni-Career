namespace FastFood.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Item
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public int CategoryId { get; set; }
		
		public Category Category { get; set; }

		public decimal Price { get; set; }

		public ICollection<Order> OrderItems { get; set; }
	}
}