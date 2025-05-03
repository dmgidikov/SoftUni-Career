namespace FootballBetting.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> country)
        {
            country.HasKey(c => c.Id);

            country
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired(true)
                .IsUnicode(false);
        }
    }
}