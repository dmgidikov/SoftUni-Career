namespace ProductShop.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string? SellerFullName { get; set; }
    }
}