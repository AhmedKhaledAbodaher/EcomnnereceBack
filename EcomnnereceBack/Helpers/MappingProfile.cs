using AutoMapper;
using Core.Dtos;
using EcomnnereceBack.Entities;

namespace EcomnnereceBack.Helpers
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductReturenDto>()
                .ForMember(d=>d.ProductBrand,o=>o.MapFrom(s=>s.ProductBrand.Name))
                .ForMember(d=>d.ProductType,o=>o.MapFrom(s=>s.ProductType.Name))
                .ForMember(d=>d.ImageUrl,o=>o.MapFrom<ProductUrlResolver>());
        }
    }
}
