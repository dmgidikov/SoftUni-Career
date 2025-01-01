namespace _7.MilitaryElite.Models
{
    using Contracts;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<ISoldier> _privates;

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            _privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates =>
            (IReadOnlyCollection<ISoldier>)_privates;

        public void AddPrivate(ISoldier @private)
        {
            _privates.Add(@private);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb
                .AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var soldier in _privates)
            {
                sb.AppendLine(soldier.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}