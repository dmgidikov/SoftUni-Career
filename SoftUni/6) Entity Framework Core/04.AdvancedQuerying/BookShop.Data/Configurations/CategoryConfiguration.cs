namespace BookShop.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired(true)
                .IsUnicode(true);

            builder
                .HasMany(x => x.CategoryBooks)
                .WithMany(x => x.BookCategories);
        }
    }
}