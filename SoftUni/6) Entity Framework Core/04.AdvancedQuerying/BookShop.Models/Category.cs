﻿namespace BookShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public ICollection<Book> CategoryBooks { get; set; } = new HashSet<Book>();
    }
}