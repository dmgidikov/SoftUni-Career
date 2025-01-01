namespace _7.MilitaryElite.Models
{
    using Contracts;

    public class Private : Soldier, IPrivate
    {
        private decimal _salary;

        public Private(int id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary
        { 
            get => _salary;
            private set
            {
                _salary = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary}";
        }
    }
}