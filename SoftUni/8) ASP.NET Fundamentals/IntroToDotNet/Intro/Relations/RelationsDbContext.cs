using Microsoft.EntityFrameworkCore;

namespace Relations
{
    public class RelationsDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (builder.IsConfigured == false)
            {
                builder.UseSqlServer($"Server=DESKTOP-KMLVDNC\\SQLEXPRESS;Database=Relations;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            }

            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Employee>()
                .HasOne(e => e.Manager)
                .WithMany(m => m.Slaves)
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
