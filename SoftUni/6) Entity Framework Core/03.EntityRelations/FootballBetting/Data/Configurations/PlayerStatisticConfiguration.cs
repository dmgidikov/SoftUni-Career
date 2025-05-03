namespace FootballBetting.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PlayerStatisticConfiguration : IEntityTypeConfiguration<PlayerStatistic>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistic> ps)
        {
            ps.HasKey(ps => new { ps.GameId, ps.PlayerId });

            ps.HasOne(ps => ps.Player)
                   .WithMany(p => p.PlayerStatistics)
                   .HasForeignKey(ps => ps.PlayerId);

            ps.HasOne(ps => ps.Game)
                   .WithMany(g => g.PlayerStatistics)
                   .HasForeignKey(ps => ps.GameId);
        }
    }
}