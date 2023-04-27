using Core.Entities;
using EcomnnereceBack.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Config
{
    internal class ProductBrandConfigration : IEntityTypeConfiguration<ProductBrand>
    {
        public void Configure(EntityTypeBuilder<ProductBrand> builder)
        {
            builder.HasData(
                new ProductBrand() {Id=1,Name= "Angular" },
                new ProductBrand() {Id=2,Name= "NetCore" },
                new ProductBrand() {Id=3,Name= "Angular" },
                new ProductBrand() {Id=4,Name= "VS Code" },
                new ProductBrand() {Id=5,Name= "Redis" },
                new ProductBrand() {Id=6,Name= "Typescript" }
              
                
                );
        }
    }
}
