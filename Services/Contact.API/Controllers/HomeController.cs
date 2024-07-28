using Contact.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }
      

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(string id)
        {
            var result = await _mediator.Send(new GetProductQuery(){Id = id});
            return await Task.FromResult<ActionResult>(Ok(result));
        }
    }
}
