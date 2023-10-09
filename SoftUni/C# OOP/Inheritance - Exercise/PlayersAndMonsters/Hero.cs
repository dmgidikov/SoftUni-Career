using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersAndMonsters
{
    public abstract class Hero
    {
        private const int MIN_LVL = 0;

        private string username;
        private int level;

        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public string Username
        { 
            get => this.username;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username cannot be null or whitespace!");
                }

                this.username = value;
            }
        }

        public int Level
        {
            get => this.level;
            private set
            {
                if (value < MIN_LVL)
                {
                    throw new ArgumentException("Level cannot be less than 0");
                }

                this.level = value;
            }
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
