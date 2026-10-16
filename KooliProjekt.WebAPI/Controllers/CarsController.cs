using System.Threading.Tasks;
using KooliProjekt.Application.Features.Cars;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace KooliProjekt.WebAPI.Controllers
{
    public class CarsController : ApiControllerBase 
    {
        private readonly IMediator _mediator;

        public CarsController(IMediator mediator)
        {
            _mediator = mediator; 
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if(id <= 0)
            {
                return NotFound();
            }

            var query = new GetCarQuery {Id = id };
            var result = await _mediator.Send(query);

            if(result == null )
            {
                return NotFound();
            }

            return Json(result);
        }

        [HttpGet("list")]
        public async Task<IActionResult> List()
        {
            var query = new ListCarQuery();
            var result = await _mediator.Send(query);

            return Json(result);
        }
    }
}
