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
        public ProductController(IProductRpository prod )
        {
            this.prod = prod;
            
        }
        [HttpGet]
        public async Task<ActionResult>  GetAll()
        {

            return Ok(await prod.GetAll()) ;
        }
    }
}
