using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentACarsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public RentACarsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet("{locationId}/{available}")]
        public async Task<IActionResult> GetRenACarFilterList(int locationId, bool available)
        {
            return Ok(await _mediatR.Send(new GetRentACarFilterQeury(locationId, available)));
        }
    }
}
