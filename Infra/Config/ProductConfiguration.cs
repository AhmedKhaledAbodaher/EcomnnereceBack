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
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ImageUrl).HasMaxLength(600);
            builder.Property(x => x.Price).HasColumnType("decimal");
            builder.HasOne(x => x.ProductBrand).WithMany().HasForeignKey(x=>x.ProductBrandId);
            builder.HasOne(x => x.ProductType).WithMany().HasForeignKey(x=>x.ProductTypeId);
            builder.HasData(
                new Product()
                {
                    Id=1,
                    Name = "Angular Speedster Board 2000",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna",
                    Price = 133,
                    ImageUrl = "images/products/sb-ang1.png",
                    ProductTypeId = 1,
                    ProductBrandId = 1,
                },  new Product()
                {
                    Id = 2,

                    Name = "Angular Speedster wwww",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna",
                    Price = 133,
                    ImageUrl = "images/products/sb-ang2.png",
                    ProductTypeId = 1,
                    ProductBrandId = 1,
                },  new Product()
                {
                    Id = 3,

                    Name = "Angular Speedster Board 2000",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna",
                    Price = 133,
                    ImageUrl = "images/products/sb-core1.png",
                    ProductTypeId = 1,
                    ProductBrandId = 2,
                },  new Product()
                {
                    Id = 4,

                    Name = "Angular Speedster Board 2000",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna",
                    Price = 133,
                    ImageUrl = "images/products/sb-react1.png",
                    ProductTypeId = 1,
                    ProductBrandId = 4,
                },  new Product()
                {
                    Id = 5,

                    Name = "Angular  Board 2000",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna",
                    Price = 133,
                    ImageUrl = "images/products/sb-ang1.png",
                    ProductTypeId = 1,
                    ProductBrandId = 2,
                },  new Product()
                {
                    Id = 6,

                    Name = "Angular  Board 2000",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna",
                    Price = 133,
                    ImageUrl = "images/products/sb-ang1.png",
                    ProductTypeId = 1,
                    ProductBrandId = 1,
                }

);
        }
    }
}


