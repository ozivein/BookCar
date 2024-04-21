using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public ReservationsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> ReservationList()
        {
            return Ok(await _mediatR.Send(new GetReservationQuery()));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReservation(int id)
        {
            return Ok(await _mediatR.Send(new GetReservationByIdQuery(id)));

        }
        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationCommand createReservationCommand)
        {
            await _mediatR.Send(createReservationCommand);
            return Ok("Rezervasyon Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReservation(UpdateReservationCommand updateReservationCommand)
        {
            await _mediatR.Send(updateReservationCommand);
            return Ok("Rezervasyon Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            await _mediatR.Send(new RemoveReservationCommand(id));
            return Ok("Rezervasyon silindi");
        }
    }
}
