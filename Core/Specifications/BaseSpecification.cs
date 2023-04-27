using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
            
        }
        public BaseSpecification(Expression<Func<T, bool>> cer )
        {
            Gertires = cer;
        }
        public Expression<Func<T, bool>> Gertires { get; } 

        public List<Expression<Func<T, object>>> Includes { get; } =new List<Expression<Func<T, object>>>();

        public void AddInclude(Expression<Func<T, object>> inc) { 
        
        Includes.Add(inc);
        }
    }
}
