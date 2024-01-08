using Application.Context;
using Application.Interfaces.Repositories;
using Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly ETicaretDbsContext context;

        public ReadRepository(ETicaretDbsContext context)
        {
            this.context = context;
        }

        public async Task<T> Get(Expression<Func<T, bool>> method, bool trackChanges = false)
        {
            var result = await context.Set<T>().SingleOrDefaultAsync(method);
            return result;
        }

        public async Task <IList<T>> GetAll(bool trackChanges = false)
        {
            var result = await context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<IList<T>> GetWhere(Expression<Func<T, bool>>? method, bool tracking = true)
        {
            var result = await context.Set<T>().Where(method).ToListAsync();
            return result;
        }

      
    }
}
