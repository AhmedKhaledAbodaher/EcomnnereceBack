using AutoMapper;
using Core.Dtos;
using EcomnnereceBack.Entities;
using Infra.Data;
using Infra.IRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcomnnereceBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRpository prod;
        private readonly IMapper Mapper;
        private readonly IGenericRepository<Product> product;

        public ProductController(IProductRpository prod , IGenericRepository<Product> genric, IMapper _Mapper)
        {
            this.prod = prod;
             this.product = genric;    
             this.Mapper=_Mapper;
        }
        [HttpGet]
        public async Task<ActionResult>  GetAll()
        {
            var spec = new ProductWithtypeandbrands();
            var products = await product.GetListAsync(spec);
            return Ok(products) ;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id )
        {
            var spec = new ProductWithtypeandbrands(id);
            var products = await product.GetWhereAsync(spec);
            Mapper.Map<Product,ProductReturenDto>(products);
            return Ok(Mapper.Map<Product, ProductReturenDto>(products));
        }
    }
}
