namespace FootballBetting.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BetConfiguration : IEntityTypeConfiguration<Bet>
    {
        public void Configure(EntityTypeBuilder<Bet> bet)
        {
            bet.HasKey(x => x.Id);

            bet
                .Property(b => b.Amount);

            bet 
                .Property(b => b.Prediction)
                .HasMaxLength(10)
                .IsRequired(true)
                .IsUnicode(false);

            bet
                .Property(b => b.DateTime)
                .IsRequired(true);

            bet     
                .HasOne(b => b.User)
                .WithMany(u => u.Bets)
                .HasForeignKey(b => b.UserId);

            bet
               .HasOne(b => b.Game)
               .WithMany(g => g.PlacedBets)
               .HasForeignKey(b => b.GameId);
        }
    }
}