using Application.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.Products
{
    public class GetAllProductsQueryResponse
    {
        public IList<ProductDto> ProductDtos { get; set; }
    }
}
