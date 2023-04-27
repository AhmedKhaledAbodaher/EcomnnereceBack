using Core.Entities;
using EcomnnereceBack.Data;
using EcomnnereceBack.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infra.Data
{
    public class SeedStoreContext
    {

        public static async Task SeedAsync(StoreContext contex) 
        {

            if (!contex.ProductBrands.Any())
            {

                var brandData = File.ReadAllText("../Infra/SeedData/brands.json");

                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandData);
                contex.ProductBrands.AddRange(brands);
            }
            
            if (!contex.ProductTypes.Any())
            {

                var ProductTypeData = File.ReadAllText("../Infra/SeedData/types.json");

                var ProductTypes = JsonSerializer.Deserialize<List<ProductType>>(ProductTypeData);
                contex.ProductTypes.AddRange(ProductTypes);
            }
            
            if (!contex.Products.Any())
            {

                var prodData = File.ReadAllText("../Infra/SeedData/brands.json");

                var prods = JsonSerializer.Deserialize<List<Product>>(prodData);
                contex.Products.AddRange(prods);
            }
            if (contex.ChangeTracker.HasChanges())
                await contex.SaveChangesAsync();
            {

            }

        }
    }
}
