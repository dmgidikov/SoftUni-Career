namespace BlackFriday.Models
{
    public class Admin : User
    {
        private const bool DefaultDataAccess = true;

        public Admin(string userName, string email) 
            : base(userName, email, DefaultDataAccess)
        {
        }
    }
}