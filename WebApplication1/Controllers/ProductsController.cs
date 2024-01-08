using Application.Features.Queries.Products;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController
    {

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetAllProductsQueryRequest request)
        {
            GetAllProductsQueryResponse response =await Mediator.Send(request);
            return Ok(response);

        }

    }
}
