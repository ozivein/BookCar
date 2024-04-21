using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagCloudsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            var values = await _mediator.Send(new GetTagCloudQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagCloud(int id)
        {
            var values = await _mediator.Send(new GetTagCloudByIdQuery(id));
            return Ok(values);
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetTagCloudByBlogIdList(int id)
        {
            var values = await _mediator.Send(new GetTagCloudByBlogIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommand createTagCloudCommand)
        {
            await _mediator.Send(createTagCloudCommand);
            return Ok("Etiket bilgisi Eklendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveTagCloud(int id)
        {
            await _mediator.Send(new RemoveTagCloudCommand(id));
            return Ok("Etiket bilgisi silindi");
        }

        [HttpPut]
        public async Task<IActionResult> TagCloudUpdate(UpdateTagCloudCommand updateTagCloudCommand)
        {
            await _mediator.Send(updateTagCloudCommand);
            return Ok("Etiket bilgisi güncellendi");
        }
    }
}
