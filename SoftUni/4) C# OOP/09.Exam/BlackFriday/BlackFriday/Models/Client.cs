namespace BlackFriday.Models
{
    public class Client : User
    {
        private readonly Dictionary<string, bool> _purchases;

        private const bool DefaultDataAccess = false;

        public Client(string userName, string email)
            : base(userName, email, DefaultDataAccess)
        {
            _purchases = new Dictionary<string, bool>();
        }

        public IReadOnlyDictionary<string, bool> Purchases => _purchases;

        public void PurchaseProduct(string productName, bool blackFridayFlag) => _purchases.Add(productName, blackFridayFlag);
    }
}