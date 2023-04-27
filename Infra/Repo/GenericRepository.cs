using Core.Entities;
using Core.Specifications;
using EcomnnereceBack.Data;
using Infra.Data;
using Infra.IRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext ctx;
        public GenericRepository(StoreContext ctx)
        {
            this.ctx = ctx; 
        }
        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await ctx.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await ctx.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> GetListAsync(ISpecification<T> a)
        {
            return await ApplaySpecifications(a).ToListAsync();
        }

        public async Task<T> GetWhereAsync(ISpecification<T> a)
        {
            return await ApplaySpecifications(a).FirstOrDefaultAsync(); ;
        }


        private IQueryable<T> ApplaySpecifications(ISpecification<T> spec)
        {
            return SpecificationsEvaluator<T>.GetQeury(ctx.Set<T>().AsQueryable(), spec);
        
        }
    }
}
