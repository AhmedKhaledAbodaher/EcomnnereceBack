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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ImageUrl).HasMaxLength(600);
            builder.Property(x => x.Price).HasColumnType("decimal");
            builder.HasOne(x => x.ProductBrand).WithMany().HasForeignKey(x=>x.ProductBrandId);
            builder.HasOne(x => x.ProductType).WithMany().HasForeignKey(x=>x.ProductTypeId);

        }
    }
}
