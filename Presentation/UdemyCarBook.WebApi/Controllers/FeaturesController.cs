using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public FeaturesController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }


        [HttpGet]
        public async Task<IActionResult> FeatureList()
        {
            return Ok(await _mediatR.Send(new GetFeatureQuery()));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeature(int id)
        {
            return Ok(await _mediatR.Send(new GetFeatureByIdQuery(id)));

        }
        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureCommand createFeatureCommand)
        {
            await _mediatR.Send(createFeatureCommand);
            return Ok("Özellik Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureCommand updateFeatureCommand)
        {
            await _mediatR.Send(updateFeatureCommand);
            return Ok("Özellik Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _mediatR.Send(new RemoveFeatureCommand(id));
            return Ok("Özellik silindi");
        }

    }
}
