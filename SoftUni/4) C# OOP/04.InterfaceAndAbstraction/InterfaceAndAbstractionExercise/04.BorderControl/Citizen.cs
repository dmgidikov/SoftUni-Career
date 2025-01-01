namespace BorderControl
{
    public class Citizen
    {
        private string _id;
        private string _name;
        private int _age;

        public Citizen(string id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }

        public string Id
        {
            get => _id;
            private set => _id = value;
        }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                _name = value;
            }
        }

        public int Age
        {
            get => _age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid age!");
                }
                _age = value;
            }
        }
    }
}