﻿namespace HandmadeHTTP.ByTheCake.Data.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public List<OrderProduct> Products { get; set; } = new List<OrderProduct>();
    }
}
