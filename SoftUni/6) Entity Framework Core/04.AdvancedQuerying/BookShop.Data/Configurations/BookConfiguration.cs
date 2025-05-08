namespace BookShop.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.BookId);

            builder.Property(x => x.Title)
                .HasMaxLength(50)
                .IsRequired(true)
                .IsUnicode(true);

            builder.Property(x => x.Description)
                .HasMaxLength(100)
                .IsRequired(true)
                .IsUnicode(true);

            builder.Property(x => x.Description)
              .HasMaxLength(100)
              .IsRequired(true)
              .IsUnicode(true);

            builder.Property(x => x.ReleaseDate)
              .IsRequired(false);

            builder.Property(x => x.Copies)
              .IsRequired(true);

            builder.Property(x => x.Price)
              .IsRequired(true);

            builder.Property(x => x.EditionType)
              .IsRequired(true);


            builder.Property(x => x.AgeRestriction)
              .IsRequired(true);

            builder
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);
        }
    }
}