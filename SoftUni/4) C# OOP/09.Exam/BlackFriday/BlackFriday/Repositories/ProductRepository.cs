namespace BlackFriday.Repositories
{
    using Contracts;
    using Models.Contracts;

    public class ProductRepository : IRepository<IProduct>
    {
        private readonly ICollection<IProduct> _models;

        public ProductRepository()
        {
            _models = new List<IProduct>();
        }

        public IReadOnlyCollection<IProduct> Models => _models as IReadOnlyCollection<IProduct>;

        public void AddNew(IProduct model) => _models.Add(model);

        public IProduct GetByName(string name)
        {
            IProduct product = null;

            if (Models.Any(x => x.ProductName == name))
            {
                product = _models.FirstOrDefault(x => x.ProductName == name);
            }

            return product;
        }

        public bool Exists(string name) => _models.Any(x => x.ProductName == name);
    }
}