using AutoMapper;
using ProductShop.DTO;
using ProductShop.Models;
using System.Linq;

namespace ProductShop
{
    public class ProductShopProfile : Profile
    {
        public ProductShopProfile()
        {
            this.CreateMap<Product, ProductDetailsDTO>();
            this.CreateMap<User, SoldProductsDTO>()
                .ForMember(x => x.Count, y => y.MapFrom(x => x.ProductsSold
                .Where(x => x.Buyer != null).Count()))
                .ForMember(x => x.Products, y => y.MapFrom(x => x.ProductsSold
                .Where(x => x.Buyer != null)));

            this.CreateMap<User, UserDetailsDTO>()
                .ForMember(x => x.SoldProducts, y => y.MapFrom(x => x));
        }
    }
}
