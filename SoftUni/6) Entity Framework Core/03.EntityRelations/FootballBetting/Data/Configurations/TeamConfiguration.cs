namespace FootballBetting.Data.Configurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> team)
        {
            team.HasKey(t => t.Id);

            team
                .Property(t => t.Name)
                .HasMaxLength(100)
                .IsRequired(true)
                .IsUnicode(false);

            team
                .Property(t => t.Initials)
                .HasMaxLength(5)
                .IsRequired(true)
                .IsUnicode(false);

            team
                .Property(t => t.LogoUrl)
                .HasMaxLength(255)
                .IsRequired(true)
                .IsUnicode(false);

            team
                .Property(t => t.Budget)
                .IsRequired(true);

            team
                .HasOne(t => t.PrimaryKitColor)
                .WithMany(pk => pk.PrimaryKitTeams)
                .HasForeignKey(t => t.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.NoAction);

            team
                .HasOne(t => t.SecondaryKitColor)
                .WithMany(pk => pk.SecondaryKitTeams)
                .HasForeignKey(t => t.SecondaryKitColorId)
                .OnDelete(DeleteBehavior.NoAction);

            team
                .HasOne(t => t.Town)
                .WithMany(t => t.Teams)
                .HasForeignKey(t => t.TownId);
        }
    }
}