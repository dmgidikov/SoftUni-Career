namespace _05.FootballTeamGenerator.Models
{
    using Common;

    public class Player
    {
        private string _name;
        private int _endurance;
        private int _sprint;
        private int _dribble;
        private int _passing;
        private int _shooting;

        public Player(string name,
                      int endurance,
                      int sprint,
                      int dribble,
                      int passing,
                      int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalExceptions.InvalidName);
                }

                _name = value;
            }
        }

        public int Endurance
        {
            get => _endurance;
            private set
            {
                ValidateStats(value, nameof(this.Endurance));

                _endurance = value;
            }
        }

        public int Sprint
        {
            get => _sprint;
            private set
            {
                ValidateStats(value, nameof(this.Sprint));

                _sprint = value;
            }
        }

        public int Dribble
        {
            get => _dribble;
            private set
            {
                ValidateStats(value, nameof(this.Dribble));

                _dribble = value;
            }
        }

        public int Passing
        {
            get => _passing;
            private set
            {
                ValidateStats(value, nameof(this.Passing));

                _passing = value;
            }
        }

        public int Shooting
        {
            get => _shooting;
            private set
            {
                ValidateStats(value, nameof(this.Shooting));

                _shooting = value;
            }
        }

        public double GetAvarageRating()
         => _endurance + _sprint + _dribble + _passing + _shooting / 5.0;   

        private static void ValidateStats(int value, string property)
        {
            if (value < GlobalConstants.PLAYER_MIN_STAT || value > GlobalConstants.PLAYER_MAX_STAT)
            {
                throw new InvalidOperationException(string.Format
                    (GlobalExceptions.InvalidPlayerStat, property));
            }
        }
    }
}