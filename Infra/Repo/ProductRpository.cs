using Core.Entities;
using EcomnnereceBack.Data;
using EcomnnereceBack.Entities;
using Infra.IRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repo
{
    public class ProductRpository : IProductRpository
    {
        private readonly StoreContext ctx;

        public ProductRpository(StoreContext _ctx)
        {
            this.ctx = _ctx;    
            
        }
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await ctx.Products.Include(nameof(ProductBrand)).Include(nameof(ProductBrand)).ToListAsync();
        }
    }
}
