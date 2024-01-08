using Application.Context;
using Application.Interfaces.Repositories;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IBaseEntity, new()
    {

        private readonly ETicaretDbsContext context;

        public WriteRepository(ETicaretDbsContext context)
        {
            this.context = context;
        }

        public async Task AddAsync(T entity)
        {
             await context.AddAsync(entity);
            
        }

        public async Task DeleteAsync(T entity)
        {
             context.Remove(entity);

        }

        public async Task UpdateAsync(T entity)
        {
            context.Update(entity);
        }
    }
}
