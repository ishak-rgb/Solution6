using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IWriteRepository<T>
        where T : class,IBaseEntity,new()
    {
        Task AddAsync(T entity);   
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);

    }
}
