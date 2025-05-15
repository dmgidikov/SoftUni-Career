namespace ProductShop.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired(true)
                .IsUnicode(false);

            builder.Property(x => x.Price)
               .IsRequired(true);

            builder
                .HasOne(x => x.Seller)
                .WithMany(y => y.ProductsSold)
                .HasForeignKey(x => x.SellerId);

            builder
               .HasOne(x => x.Buyer)
               .WithMany(y => y.ProductsBought)
               .HasForeignKey(x => x.BuyerId);
        }
    }
}