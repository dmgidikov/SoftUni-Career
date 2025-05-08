namespace BookShop.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.AuthorId);

            builder.Property(x => x.FirstName)
                .HasMaxLength(50)
                .IsRequired(false)
                .IsUnicode(true);

            builder.Property(x => x.LastName)
                .HasMaxLength(50)
                .IsRequired(true)
                .IsUnicode(true);
        }
    }
}
