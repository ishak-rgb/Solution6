using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories
{
    public interface IReadRepository<T>
        where T : class,IBaseEntity,new() 
    {
        Task <IList<T>> GetAll(bool trackChanges = false);
        Task <IList<T>> GetWhere(Expression<Func<T, bool>> method,bool tracking = true);
        Task <T> Get(Expression<Func<T, bool>> method,bool trackChanges = false);  

    }
}
