namespace _7.MilitaryElite.Models
{
    using Contracts;
    using System.Text;

    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;   
        }

        public int CodeNumber {  get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine(base.ToString())
                .AppendLine($"Code Number: {CodeNumber}");

            return sb.ToString();
        }
    }
}