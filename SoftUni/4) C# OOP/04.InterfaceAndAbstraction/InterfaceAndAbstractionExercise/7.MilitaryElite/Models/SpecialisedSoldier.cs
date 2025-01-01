namespace _7.MilitaryElite.Models
{
    using Contracts;
    using Exceptions;
    using System.Text;
    using Enumerations;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(int id, string firstName, string lastName,
            decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = TryParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        private Corps TryParseCorps(string corspStr)
        {
            Corps corps;

            var parsed = Enum.TryParse(corspStr, out corps);

            if (parsed == false)
            {
                throw new InvalidCorpsException();
            }

            return corps;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine(base.ToString())
                .AppendLine($"Corps {this.Corps.ToString()}");

            return sb.ToString().TrimEnd();
        }
    }
}