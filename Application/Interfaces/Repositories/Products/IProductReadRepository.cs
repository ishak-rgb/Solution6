using Domain.Entities;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Repositories.Products
{
    public interface IProductReadRepository:IReadRepository<Product>
    {
    }
}
