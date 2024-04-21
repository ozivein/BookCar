using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public AboutsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _mediatR.Send(new GetAboutQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var values = await _mediatR.Send(new GetAboutByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand createAboutCommand)
        {
            await _mediatR.Send(createAboutCommand);
            return Ok("Hakkımda bilgisi Eklendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _mediatR.Send(new RemoveAboutCommand(id));
            return Ok("Hakkımda bilgisi silindi");
        }

        [HttpPut]
        public async Task<IActionResult> AboutUpdate(UpdateAboutCommand updateAboutCommand)
        {
            await _mediatR.Send(updateAboutCommand);
            return Ok("Hakkımda bilgisi güncellendi");
        }

    }
}
