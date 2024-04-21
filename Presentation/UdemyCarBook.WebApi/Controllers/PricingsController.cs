using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public PricingsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }


        [HttpGet]
        public async Task<IActionResult> PricingList()
        {
            return Ok(await _mediatR.Send(new GetPricingQuery()));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPricing(int id)
        {
            return Ok(await _mediatR.Send(new GetPricingByIdQuery(id)));

        }
        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatePricingCommand createPricingCommand)
        {
            await _mediatR.Send(createPricingCommand);
            return Ok("Fiyat Bilgisi Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommand updatePricingCommand)
        {
            await _mediatR.Send(updatePricingCommand);
            return Ok("Fiyat Bilgisi Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePricing(int id)
        {
            await _mediatR.Send(new RemovePricingCommand(id));
            return Ok("Fiyat Bilgisi silindi");
        }

    }
}
