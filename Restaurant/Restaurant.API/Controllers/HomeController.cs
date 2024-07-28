using System.Runtime.CompilerServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Application.Queries;

namespace Restaurant.API.Controllers
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
        public async  Task<ActionResult> GetRestaurant(string id)
        {
            var result=await _mediator.Send(new GetCustomerQuery(){Id = id});
            return await Task.FromResult<ActionResult>(Ok(result));
        }
    }
}
