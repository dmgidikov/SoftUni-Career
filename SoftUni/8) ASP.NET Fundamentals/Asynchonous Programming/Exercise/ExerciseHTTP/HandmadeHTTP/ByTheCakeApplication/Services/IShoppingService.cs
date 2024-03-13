namespace HandmadeHTTP.ByTheCake.Services
{
    public interface IShoppingService
    {
        void CreateOrder(int userId, IEnumerable<int> productIds);
    }
}