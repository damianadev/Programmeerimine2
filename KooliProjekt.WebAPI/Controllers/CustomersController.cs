using System.Threading.Tasks;
using KooliProjekt.Application.Features.Customers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace KooliProjekt.WebAPI.Controllers
{
    public class CustomersController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var query = new GetCustomerQuery { Id = id };
            var result = await _mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }

            return Json(result);
        }

        [HttpGet("list")]
        public async Task<IActionResult> List()
        {
            var query = new ListCustomerQuery();
            var result = await _mediator.Send(query);

            return Json(result);
        }

        [HttpGet("list/{page}/{pageSize}")]
        public async Task<IActionResult> List(int page, int pageSize)
        {
            var query = new ListCustomerQuery
            {
                Page = page,
                PageSize = pageSize
            };
            var result = await _mediator.Send(query);

            return Result(result);
        }
    }
}
