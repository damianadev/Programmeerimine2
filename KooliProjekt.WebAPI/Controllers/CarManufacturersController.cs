using KooliProjekt.Application.Features.CarManufacturers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Threading.Tasks;

namespace KooliProjekt.WebAPI.Controllers
{
    public class CarManufacturersController : ApiControllerBase
    {
        private readonly IMediator _mediator;

        public CarManufacturersController(IMediator mediator)
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

            var query = new GetCarManufacturerQuery { Id = id };
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
            var query = new ListCarManufacturerQuery();
            var result = await _mediator.Send(query);

            return Json(result);
        }
    }
}
