namespace FastFood.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Customer)
                .HasMaxLength(30)
                .IsRequired(true)
                .IsUnicode(false);

            builder.Property(x => x.DateTime)
                .IsRequired();

            builder.Property(x => x.Type)
                .IsRequired();

            builder.HasOne(x => x.Employee)
                .WithMany(y => y.Orders) 
                .HasForeignKey(x => x.EmployeeId)
                .IsRequired();
        }
    }
}