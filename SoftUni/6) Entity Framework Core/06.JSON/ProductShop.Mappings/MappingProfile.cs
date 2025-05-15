namespace ProductShop.Mapping
{
    using Dtos;
    using Models;
    using AutoMapper;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(x => x.FullName,
                    y => y.MapFrom(
                        x => string.IsNullOrEmpty(x.FirstName)
                        ? x.LastName
                        : $"{x.FirstName} {x.LastName}"));

            CreateMap<Product, ProductDto>()
                .ForMember(x => x.SellerFullName,
                y => y.MapFrom(
                    x => x.Seller == null
                    ? "Unknown Seller"
                    : (string.IsNullOrEmpty(x.Seller.FirstName)
                        ? x.Seller.LastName
                        : $"{x.Seller.FirstName} {x.Seller.LastName}")));

            CreateMap<Category, CategoryDto>()
                .ForMember(x => x.ProductsCount, y => y.MapFrom(x => x.Products.Count));
        }
    }
}