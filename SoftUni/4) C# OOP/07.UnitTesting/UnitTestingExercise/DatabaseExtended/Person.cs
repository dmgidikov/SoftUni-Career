namespace ExtendedDatabase
{
    public class Person
    {
        private long id;
        private string userName;

        public Person(long id, string userName)
        {
            this.Id = id;
            this.UserName = userName;
        }

        public string UserName
        {
            get => userName;
            private set => userName = value;
        }

        public long Id
        {
            get => this.id;
            private set => this.id = value;
        }
    }
}
