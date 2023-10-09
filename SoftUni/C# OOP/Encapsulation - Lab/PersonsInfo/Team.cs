using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
        public const int CHECK_AGE = 40;

        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get => this.firstTeam.AsReadOnly();
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get => this.reserveTeam.AsReadOnly();
        }

        public void AddPlayer(Person person)
        {
          // person.Age < CHECK_AGE ? firstTeam.Add(person) : secondTeam.Add(person);

            if (person.Age < CHECK_AGE)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First team has {firstTeam.Count} players.");
            sb.AppendLine($"Reserve  team has {ReserveTeam.Count} players.");

            return sb.ToString().TrimEnd();
        }
    }
}
