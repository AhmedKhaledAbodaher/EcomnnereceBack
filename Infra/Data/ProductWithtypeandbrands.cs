using Core.Specifications;
using EcomnnereceBack.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    public class ProductWithtypeandbrands:BaseSpecification<Product>
    {
        public ProductWithtypeandbrands()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
        public ProductWithtypeandbrands(int id ):base(x=>x.Id==id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}
