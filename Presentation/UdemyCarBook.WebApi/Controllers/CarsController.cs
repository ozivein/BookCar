using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public CarsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> CarList()
        {
            var values = await _mediatR.Send(new GetCarQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var values = await _mediatR.Send(new GetCarByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand createCarCommand)
        {
            await _mediatR.Send(createCarCommand);
            return Ok("Araç Eklendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveCar(int id)
        {
            await _mediatR.Send(new RemoveCarCommand(id));
            return Ok("Araç silindi");
        }

        [HttpPut]
        public async Task<IActionResult> CarUpdate(UpdateCarCommand updateCarCommand)
        {
            await _mediatR.Send(updateCarCommand);
            return Ok("Araç güncellendi");
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCarWithBrand()
        {
            var values = await _mediatR.Send(new GetCarWithBrandQuery());
            return Ok(values);
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetLastFiveCarWithBrand()
        {
            var values = await _mediatR.Send(new GetLastFiveCarWithBrandQuery());
            return Ok(values);
        }
    }
}
