using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries.CarDescrpitonQueries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarDescriptionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarDescriptionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{CarId}")]

        public async Task<IActionResult> GetCarDescrpitonByCarId(int CarId)
        {
            return Ok(await _mediator.Send(new GetCarDescriptionByCarIdQuery(CarId)));
        }
    }
}
