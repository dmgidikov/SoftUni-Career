namespace BlackFriday.Models
{
    using Contracts;
    using Repositories;
    using Repositories.Contracts;

    public class Application : IApplication
    {
        private readonly IRepository<IProduct> _products;
        private readonly IRepository<IUser> _users;

        public Application()
        {
            _products = new ProductRepository();
            _users = new UserRepository();
        }

        public IRepository<IProduct> Products => _products;

        public IRepository<IUser> Users => _users;
    }
}