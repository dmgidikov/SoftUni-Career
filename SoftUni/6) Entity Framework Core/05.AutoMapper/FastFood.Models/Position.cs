namespace FastFood.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Position
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public ICollection<Employee> Employees { get; set; }
	}
}