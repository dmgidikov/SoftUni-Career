namespace FastFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Enums;

    public class Order
	{
		public int Id { get; set; }
		
		public string Customer { get; set; }

		public DateTime DateTime { get; set; }

		public OrderType Type { get; set; }

		public decimal TotalPrice { get; set; }

		public int EmployeeId { get; set; }

		public Employee Employee { get; set; }

		public ICollection<Item> OrderItems { get; set; }
	}
}