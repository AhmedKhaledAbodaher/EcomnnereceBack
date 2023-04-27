using Core.Entities;
using Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    public class SpecificationsEvaluator<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQeury(IQueryable<TEntity> inputqe, ISpecification<TEntity> spec)
        {

            var qu = inputqe;
            if (spec.Gertires !=null)
            {
                qu = qu.Where(spec.Gertires);
            };
            qu = spec.Includes.Aggregate(qu, (current, include) => current.Include(include));
            return qu;
        }
    }
}
