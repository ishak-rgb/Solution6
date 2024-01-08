using Application.Interfaces.Repositories.Products;
using MediatR;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Application.DTOs;

namespace Application.Features.Queries.Products
{
    public class GetAllProductsQueryRequestHandler : IRequestHandler<GetAllProductsQueryRequest,GetAllProductsQueryResponse>
    {
        private readonly IProductReadRepository repository;
        private readonly IMapper mapper;

        public GetAllProductsQueryRequestHandler(IProductReadRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<GetAllProductsQueryResponse> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var response =await repository.GetAll();

           var result = mapper.Map<IList<Product>, IList<ProductDto>>(response);

            var res = new GetAllProductsQueryResponse()
            {
                ProductDtos = result
            }; 
            return res;
        

            //var result = products.Select(p => new GetAllProductsQueryResponse
            //{
            //    ProductId = p.ProductId,
            //    CategoryId = p.CategoryId,
            //    Description = p.Description,
            //    Price = p.Price,
            //    ProductName = p.ProductName
            //});

          
        }
    }
}
