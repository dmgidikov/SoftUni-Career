namespace BlackFriday.Repositories
{
    using Contracts;
    using Models.Contracts;

    public class UserRepository : IRepository<IUser>
    {
        private readonly ICollection<IUser> _models;

        public UserRepository()
        {
            _models = new List<IUser>();
        }

        public IReadOnlyCollection<IUser> Models => _models as IReadOnlyCollection<IUser>;

        public void AddNew(IUser model) => _models.Add(model);

        public IUser GetByName(string name)
        {
            IUser user = null;

            if (_models.Any(x => x.UserName == name))
            {
                user = _models.FirstOrDefault(x => x.UserName == name);
            }

            return user;
        }

        public bool Exists(string name) => _models.Any(x => x.UserName == name);
    }
}
