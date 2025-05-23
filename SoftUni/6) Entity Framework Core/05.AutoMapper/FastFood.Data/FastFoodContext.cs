﻿namespace FastFood.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class FastFoodContext : DbContext
    {
        public FastFoodContext()
        {

        }

        public FastFoodContext(DbContextOptions<FastFoodContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Position> Positions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(FastFoodContext).Assembly);
        }       
    }
}
