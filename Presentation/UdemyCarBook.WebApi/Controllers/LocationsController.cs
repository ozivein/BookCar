using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public LocationsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> LocationList()
        {
            return Ok(await _mediatR.Send(new GetLocationQuery()));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocation(int id)
        {
            return Ok(await _mediatR.Send(new GetLocationByIdQuery(id)));

        }
        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationCommand createLocationCommand)
        {
            await _mediatR.Send(createLocationCommand);
            return Ok("Lokasyon Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommand updateLocationCommand)
        {
            await _mediatR.Send(updateLocationCommand);
            return Ok("Lokasyon Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            await _mediatR.Send(new RemoveLocationCommand(id));
            return Ok("Lokasyon silindi");
        }

    }
}
