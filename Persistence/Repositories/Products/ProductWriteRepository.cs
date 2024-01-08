using Application.Context;
using Application.Interfaces.Repositories.Products;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Products
{
    public class ProductWriteRepository:WriteRepository<Product>,IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretDbsContext context):base(context)
        {
            
        }
    }
}
