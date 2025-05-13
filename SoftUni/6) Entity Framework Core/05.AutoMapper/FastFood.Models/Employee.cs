namespace FastFood.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Employee
	{
		public int Id { get; set; }
		
		public string Name { get; set; }

		public int Age { get; set; }

	    public string Address { get; set; }

        public int PositionId { get; set; }

		public Position Position { get; set; }

		public ICollection<Order> Orders { get; set; }
	}
}