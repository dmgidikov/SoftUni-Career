namespace _03.PlayersAndMonsters
{
    public class Hero
    {
        private string _name;
        private int _level;

        public Hero(string username, int level)
        {
            this._name = username;
            this._level = level;
        }

        public string Username => this._name;

        public int Level => this._level;

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}