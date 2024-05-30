using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionAPI.Application.Features.Products.Command.Queries.GetAllProducts;
using OnionAPI.Application.Interfaces.IUnitOfWorks;

namespace OnionAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IUnitOfWork unitOfWork;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]   

        public async Task <IActionResult> GetAllProducts()
        {
            var response = await mediator.Send(new GetAllProductQueryRequest());
            return Ok(response);
        }
    }
}
