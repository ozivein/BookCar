using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricings : ControllerBase
    {
        private readonly IMediator _mediatR;

        public CarPricings(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> CarPricingWithCarsList()
        {
            return Ok(await _mediatR.Send(new GetCarPricingWithCarsQuery()));
        }

        [HttpGet("[action]")]

        public async Task<IActionResult> GetCarPricingWithTimePeriod()
        {
            return Ok(await _mediatR.Send(new GetCarPricingWithTimePeriodQuery()));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> CarPricingWithCarsDayList()
        {
            return Ok(await _mediatR.Send(new GetCarPricingWithCarsDayQuery()));
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetCarPricing(int id)
        {
            return Ok(await _mediatR.Send(new GetCarPricingByIdQuery(id)));
        }

        [HttpPost]

        public async Task<IActionResult> CreateCarPricing(CreateCarPricingCommand createCarPricingCommand)
        {
            await _mediatR.Send(createCarPricingCommand);
            return Ok("Araç Fiyatı Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCarPricing(UpdateCarPricingCommand updateCarPricingCommand)
        {
            await _mediatR.Send(updateCarPricingCommand);
            return Ok("Araç Fiyat güncellendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveCarPricing(int id)
        {
            await _mediatR.Send(new RemoveCarPricingCommand(id));
            return Ok("Araç Fiyat Silindi");
        }
    }

}
