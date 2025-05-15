namespace ProductShop.Services
{
    using Models;

    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
    }
}