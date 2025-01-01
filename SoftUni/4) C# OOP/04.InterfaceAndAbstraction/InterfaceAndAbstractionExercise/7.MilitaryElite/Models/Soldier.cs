namespace _7.MilitaryElite.Models
{
    using Contracts;

    public abstract class Soldier : ISoldier
    {
        private int _id;
        private string _firstName;
        private string _lastName;

        protected Soldier(int id, string firstName, string lastName) 
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get => _id;
            private set => _id = value;
        }

        public string FirstName
        {
            get => _firstName;
            private set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            private set => _lastName = value;
        }

        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName} Id: {Id}";
        }
    }
}