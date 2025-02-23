namespace BlackFriday.Models.Contracts
{
    using Repositories.Contracts;

    public interface IApplication
    {
        IRepository<IProduct> Products { get; }

        IRepository<IUser> Users { get; }
    }
}