namespace FastFood.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
            .HasMaxLength(30)
            .IsRequired(true)
            .IsUnicode(false);

            builder.Property(x => x.Price)
                .IsRequired(true);

            builder
                .HasOne(x => x.Category)
                .WithMany(y => y.Items)
                .HasForeignKey(x => x.CategoryId)
                .IsRequired(true);
        }
    }
}