﻿namespace SalesDatabase.Data.Models
{
    public class Store
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
