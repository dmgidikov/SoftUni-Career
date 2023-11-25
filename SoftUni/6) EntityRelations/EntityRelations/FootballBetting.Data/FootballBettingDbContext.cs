using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Models;

namespace P03_FootballBetting.Data
{
    public class FootballBettingDbContext : DbContext
    {
        public FootballBettingDbContext()
        {

        }

        public FootballBettingDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Bet> Bets { get; set; }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(Configuration.Configuration.ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bet>(entity =>
            {
                entity.HasKey(e => e.BetId);

                entity
                    .Property(e => e.Amount)
                    .IsRequired(true);

                entity
                    .Property(e => e.Prediction)
                    .IsRequired(true);

                entity
                    .Property(e => e.DateTime)
                    .IsRequired(true);

                entity
                    .HasOne(e => e.User)
                    .WithMany(u => u.PlacedBets)
                    .HasForeignKey(e => e.UserId);

                entity
                    .HasOne(e => e.Game)
                    .WithMany(e => e.PlacedBets)
                    .HasForeignKey(e => e.GameId);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.HasKey(e => e.ColorId);

                entity
                    .Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(true)
                    .IsRequired(true);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity
                    .Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .IsRequired(true);
            });

            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(e => e.GameId);

                entity
                    .Property(e => e.HomeTeamGoals)
                    .IsRequired(true);

                entity
                   .Property(e => e.AwayTeamGoals)
                   .IsRequired(true);

                entity
                    .Property(e => e.DateTime)
                    .IsRequired(true);

                entity
                    .Property(e => e.HomeTeamBetRate)
                    .IsRequired(true);

                entity
                    .Property(e => e.AwayTeamBetRate)
                    .IsRequired(true);

                entity
                  .Property(e => e.DrawBetRate)
                  .IsRequired(true);

                entity
                    .Property(e => e.Result)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired(true);

                entity
                    .HasOne(e => e.HomeTeam)
                    .WithMany(t => t.HomeGames)
                    .HasForeignKey(e => e.HomeTeamId);

                entity
                    .HasOne(e => e.AwayTeam)
                    .WithMany(t => t.AwayGames)
                     .HasForeignKey(e => e.AwayTeamId);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity
                    .Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(true)
                    .IsRequired(true);

                entity
                    .Property(e => e.SquadNumber)
                    .IsRequired();

                entity
                    .Property(e => e.IsInjured)
                    .IsRequired(true);

                entity
                    .HasOne(e => e.Team)
                    .WithMany(t => t.Players)
                    .HasForeignKey(e => e.TeamId);

                entity
                    .HasOne(e => e.Position)
                    .WithMany(t => t.Players)
                    .HasForeignKey(e => e.PositionId);
            });

            modelBuilder.Entity<PlayerStatistic>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.GameId });

                entity
                    .Property(e => e.ScoredGoals)
                    .IsRequired(true);

                entity
                    .Property(e => e.Assists)
                    .IsRequired(true);

                entity
                    .Property(e => e.MinutesPlayed)
                    .IsRequired(true);

                entity
                    .HasOne(e => e.Player)
                    .WithMany(p => p.PlayerStatistics)
                    .HasForeignKey(e => e.PlayerId);

                entity
                    .HasOne(e => e.Game)
                    .WithMany(g => g.PlayerStatistics)
                    .HasForeignKey(e => e.GameId);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.PositionId);

                entity
                    .Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(true)
                    .IsRequired(true);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(entity => entity.TeamId);

                entity
                    .Property(entity => entity.Name)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .IsRequired(true);

                entity
                    .Property(e => e.LogoUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsRequired(false);

                entity
                    .Property(e => e.Initials)
                    .HasMaxLength(3)
                    .IsUnicode(true)
                    .IsRequired(true);

                entity
                    .Property(e => e.Budget)
                    .IsRequired(true);

                entity
                     .HasOne(e => e.PrimaryKitColor)
                     .WithMany(c => c.PrimaryKitTeams)
                     .HasForeignKey(e => e.PrimaryKitColorId);


                entity
                     .HasOne(e => e.SecondaryKitColor)
                     .WithMany(c => c.SecondKitTeams)
                     .HasForeignKey(e => e.SecondaryKitColorId);

                entity
                    .HasOne(e => e.Town)
                    .WithMany(t => t.Teams)
                    .HasForeignKey(e => e.TownId);
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.HasKey(e => e.TownId);

                entity
                    .Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .IsRequired(true);

                entity
                    .HasOne(e => e.Country)
                    .WithMany(c => c.Towns)
                    .HasForeignKey(e => e.CountryId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity
                    .Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired(true);

                entity
                    .Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .IsRequired(false);

                entity
                    .Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(true)
                    .IsRequired(false);

                entity
                    .Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsRequired(true);

                entity
                    .Property(e => e.Balance)
                    .IsRequired(true);
            });
        }
    }
}
