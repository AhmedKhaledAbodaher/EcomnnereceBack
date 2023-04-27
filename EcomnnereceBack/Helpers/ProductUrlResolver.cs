using AutoMapper;
using AutoMapper.Execution;
using Core.Dtos;
using EcomnnereceBack.Entities;

namespace EcomnnereceBack.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductReturenDto, string>

    {
        private readonly IConfiguration config;
        public ProductUrlResolver(IConfiguration _config)
        {
            this.config = _config;
        }
        public string Resolve(Product source, ProductReturenDto destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.ImageUrl))
            {
                return config["apiUrl"] + source.ImageUrl;
            }
            return null;
        }
    }
}
