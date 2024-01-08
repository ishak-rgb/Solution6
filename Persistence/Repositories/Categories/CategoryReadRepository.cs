using Application.Context;
using Application.Interfaces.Repositories.Categories;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Categories
{
    public class CategoryReadRepository:ReadRepository<Category>,ICategoryReadRepository
    {
        public CategoryReadRepository(ETicaretDbsContext context):base(context)
        {
            
        }

    }
}
