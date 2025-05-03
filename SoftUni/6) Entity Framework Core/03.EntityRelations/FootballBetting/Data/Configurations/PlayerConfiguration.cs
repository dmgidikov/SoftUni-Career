namespace FootballBetting.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> player)
        {
            player.HasKey(p => p.PlayerId);

            player.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            player.HasOne(p => p.Team)
                   .WithMany(t => t.Players)
                   .HasForeignKey(p => p.TeamId);

            player.HasOne(p => p.Position)
                   .WithMany()
                   .HasForeignKey(p => p.PositionId);
        }
    }
}