﻿namespace P03_FootballBetting.Models
{
    public class Game
    {
        public int GameId { get; set; }

        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }

        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }

        public int HomeTeamGoals { get; set; }

        public int AwayTeamGoals { get; set; }

        public DateTime DateTime { get; set; }

        public double HomeTeamBetRate { get; set; }

        public double AwayTeamBetRate { get; set; }

        public double DrawBetRate { get; set; }

        public string Result { get; set; }

        public ICollection<PlayerStatistic> PlayerStatistics { get; set; }
            = new List<PlayerStatistic>();

        public ICollection<Bet> PlacedBets { get; set; } = new List<Bet>();
    }
}