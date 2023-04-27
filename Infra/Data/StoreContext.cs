

using Core.Entities;
using EcomnnereceBack.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EcomnnereceBack.Data
{
    public class StoreContext:DbContext
    {

        public StoreContext( DbContextOptions<StoreContext> op):base(op)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
   



    }
}
