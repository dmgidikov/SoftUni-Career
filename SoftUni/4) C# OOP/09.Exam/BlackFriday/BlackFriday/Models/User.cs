namespace BlackFriday.Models
{
    using Contracts;
    using Utilities.Messages;

    public abstract class User : IUser
    {
        private string _name;
        private string _email;

        protected User(string userName, string email, bool hasDataAccess)
        {
            UserName = userName;
            Email = email;
            HasDataAccess = hasDataAccess;
        }

        public string UserName
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.UserNameRequired);
                }

                _name = value;
            }
        }

        public bool HasDataAccess { get; private set; }

        public string Email
        {
            get => _email;
            private set
            {
                if (HasDataAccess)
                {
                    _email = "hidden";
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException(ExceptionMessages.EmailRequired);
                    }

                    _email = value;
                }
            }
        }

        public override string ToString()
        {
            if (HasDataAccess)
            {
                return $"{UserName} - Status: {GetType().Name}, Contact Info: Hidden";
            }
            else
            {
                return $"{UserName} - Status: {GetType().Name}, Contact Info: {Email}";
            }
        }
    }
}