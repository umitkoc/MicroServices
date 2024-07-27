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

        [HttpGet]
        public async  Task<ActionResult> GetRestaurant([FromQuery]GetCustomerQuery query)
        {
            var result=await _mediator.Send(query);
            return await Task.FromResult<ActionResult>(Ok(result));
        }
    }
}
