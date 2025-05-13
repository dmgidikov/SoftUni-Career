namespace FastFood.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired(true)
                .IsUnicode(false);

            builder.Property(x => x.Age)
                .IsRequired(true);

            builder.Property(x => x.Address)
               .HasMaxLength(30)
               .IsRequired(true)
               .IsUnicode(false);

            builder
                .HasOne(x => x.Position)
                .WithMany(x => x.Employees)
                .HasForeignKey(x => x.PositionId)
                .IsRequired(true);
        }
    }
}