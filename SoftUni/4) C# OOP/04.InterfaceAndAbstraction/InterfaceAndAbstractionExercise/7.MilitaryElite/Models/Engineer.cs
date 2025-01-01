namespace _7.MilitaryElite.Models
{
    using Contracts;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private ICollection<IRepair> _repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary, 
            string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            _repairs = new List<IRepair>();
        }
        

        public IReadOnlyCollection<IRepair> Repairs =>
            (IReadOnlyCollection<IRepair>)_repairs;

        public void AddRepair(IRepair repair)
        {
           _repairs.Add(repair); 
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine(base.ToString())
                .AppendLine("Repairs");

            foreach (var repair in _repairs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}