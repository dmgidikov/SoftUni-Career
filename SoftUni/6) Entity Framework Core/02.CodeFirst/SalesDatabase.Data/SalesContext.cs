namespace SalesDatabase.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class SalesContext : DbContext
    {
        public SalesContext(DbContextOptions options)
            : base(options)
        {
        }

        public SalesContext()
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder != null)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-KMLVDNC\\SQLEXPRESS;Database=SalesDatabase;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity
                   .Property(p => p.Name)
                   .HasMaxLength(50)
                   .IsRequired(true)
                   .IsUnicode(true);

                entity
                   .Property(p => p.Quantity)
                   .IsRequired(true);

                entity
                   .Property(p => p.Price)
                   .IsRequired(true);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity
                    .Property(c => c.Name)
                    .HasMaxLength(100)
                    .IsRequired(true)
                    .IsUnicode(true);

                entity
                    .Property(c => c.Email)
                    .HasMaxLength(80)
                    .IsRequired(true)
                    .IsUnicode(false);

                entity
                  .Property(c => c.CreditCardNumber)
                  .IsRequired(true)
                  .IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(s => s.Id);

                entity
                    .Property(s => s.Name)
                    .HasMaxLength(80)
                    .IsRequired(true)
                    .IsUnicode(true);
            });

            modelBuilder.Entity<Sale>(entity =>
            {  
                entity.HasKey(s => s.Id);

                entity
                    .Property(s => s.Date)
                    .IsRequired(true)
                    .HasColumnType("DATETIME2");

                entity
                    .HasOne(s => s.Customer)
                    .WithMany(c => c.Sales)
                    .HasForeignKey(c => c.CustomerId);

                entity
                    .HasOne(s => s.Product)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(p => p.ProductId);

                entity
                    .HasOne(s => s.Store)
                    .WithMany(s => s.Sales)
                    .HasForeignKey(s => s.StoreId);
            });
        }
    }
}