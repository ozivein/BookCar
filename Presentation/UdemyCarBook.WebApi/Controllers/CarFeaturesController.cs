using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{CarId}")]
        public async Task<IActionResult> GetCarFeatureListByCarId(int CarId)
        {
            return Ok(await _mediator.Send(new GetCarFeatureByCarIdQeury(CarId)));
        }

        [HttpGet("[action]/{CarFeatureId}")]
        public async Task<IActionResult> ChangeCarFeatureAvailableTrue(int CarFeatureId)
        {
            await _mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(CarFeatureId));
            return Ok("Araç Özelliği Aktif Edildi");
        }
        [HttpGet("[action]/{CarFeatureId}")]
        public async Task<IActionResult> ChangeCarFeatureAvailableFalse(int CarFeatureId)
        {
            await _mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(CarFeatureId));
            return Ok("Araç Özelliği Pasif Edildi");
        }
        [HttpPost]
        public async Task<IActionResult> CreateCarFeature(CreateCarFeatureCommand createCarFeatureCommand)
        {

            await _mediator.Send(createCarFeatureCommand);
            return Ok("Araç Özelliği Eklendi");
        }
    }
}
