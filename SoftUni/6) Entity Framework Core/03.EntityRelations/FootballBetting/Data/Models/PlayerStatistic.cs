﻿namespace FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        public int GameId { get; set; }

        public int PlayerId { get; set; }

        public int ScoredGoals { get; set; }

        public int Assists { get; set; }

        public int MinutesPlayed { get; set; }

        // Navigation properties

        public Game Game { get; set; }

        public Player Player { get; set; }
    }
}