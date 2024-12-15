namespace _05.FootballTeamGenerator.Models
{
    using Common;

    public class Team
    {
        private string _name;
        private List<Player> _players;

        private Team()
        {
            _players = new List<Player>();
        }

        public Team(string name)
            : base()
        {
            this.Name = name;
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

        public IReadOnlyCollection<Player> Players => _players;

        public int Rating
        {
            get 
            {
                if (_players.Count == 0)
                {
                    return 0;
                }

                double ratings = 0;

                foreach (var player in _players)
                {
                    var currentOverall = player.GetAvarageRating();
                    ratings += currentOverall;
                }

                return (int)(ratings / _players.Count);
            }
        }

        public void AddPlayer(Player player)
        {
             _players.Add(player);            
        }

        public void RemovePlayer(Player player)
        {
            if (_players.Any(p => p.Name == player.Name) == false)
            {
                throw new InvalidOperationException(string
                    .Format(GlobalExceptions.MissingPlayer,
                    player.Name, this.Name));
            }
            else
            {
                _players.Remove(player);
            }
        }
    }
}