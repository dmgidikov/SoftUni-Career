namespace _7.MilitaryElite.Models
{
    using Contracts;
    using System.Text;

    public class Commando : SpecialisedSoldier, ICommando
    {
        private ICollection<IMission> _missions;

        public Commando(int id, string firstName, string lastName, decimal salary,
            string corps) 
            : base(id, firstName, lastName, salary, corps)
        {
        }

        public IReadOnlyCollection<IMission> Missions =>
            (IReadOnlyCollection<IMission>)_missions;

        public void AddMission(IMission mission)
        {
            _missions.Add(mission);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine(base.ToString())
                .AppendLine("Missions:");

            foreach (var mission in _missions)
            {
                sb.AppendLine(mission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}