namespace FootballBetting.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user.HasKey(x => x.Id);

            user
               .Property(u => u.UserName)
               .HasMaxLength(20)
               .IsRequired(true)
               .IsUnicode(false);

            user
               .Property(u => u.Name)
               .HasMaxLength(50)
               .IsRequired(true)
               .IsUnicode(false);

            user
               .Property(u => u.Password)
               .HasMaxLength(50)
               .IsRequired(true)
               .IsUnicode(false);

            user
               .Property(u => u.Email)
               .HasMaxLength(100)
               .IsRequired(true)
               .IsUnicode(false);

            user
               .Property(b => b.Balance)
               .IsRequired(true);
        }
    }
}