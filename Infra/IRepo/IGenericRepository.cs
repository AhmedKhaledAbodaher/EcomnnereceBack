using Core.Entities;
using Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.IRepo
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetById(int id);
        Task<T> GetWhereAsync(ISpecification<T> a);
        Task<IReadOnlyList<T>> GetAll();
        Task<IReadOnlyList<T>> GetListAsync(ISpecification<T> a);

    }
}
