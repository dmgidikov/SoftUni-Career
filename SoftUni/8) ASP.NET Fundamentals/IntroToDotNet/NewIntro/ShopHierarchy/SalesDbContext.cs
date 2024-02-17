using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopHierarchy
{
    public class SalesDbContext :DbContext
    {
        public DbSet<Customer> Customers { get; set; }  

        public DbSet<SalesMan> SalesMen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (builder.IsConfigured == false)
            {
                builder.UseSqlServer("Server=DESKTOP-KMLVDNC\\SQLEXPRESS;Database=CodeFirst;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            }
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>()
                .HasOne(c => c.SalesMan)
                .WithMany(s => s.Customers)
                .HasForeignKey(c => c.SalesmanId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Review>()
             .HasOne(r => r.Customer)
             .WithMany(c => c.Reviews)
             .HasForeignKey(r => r.CustomerId)
             .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Item>()
                .HasMany(i => i.Reviews)
                .WithOne(r => r.Item)
                .HasForeignKey(r => r.ItemId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ItemId });

            builder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.Items)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<OrderItem>()
                .HasOne(oi => oi.Item)
                .WithMany(i => i.Orders)
                .HasForeignKey(oi => oi.ItemId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
