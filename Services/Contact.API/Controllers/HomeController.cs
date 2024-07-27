﻿using Contact.Application.Queries;
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
      

        [HttpGet]
        public async Task<ActionResult> GetProduct([FromQuery]GetProductQuery productId)
        {
            var result =await _mediator.Send(productId);

            return await Task.FromResult<ActionResult>(Ok(result));
        }
    }
}
