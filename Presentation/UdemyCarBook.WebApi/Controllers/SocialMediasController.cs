using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public SocialMediasController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }


        [HttpGet]
        public async Task<IActionResult> SocialMediaList()
        {
            return Ok(await _mediatR.Send(new GetSocialMediaQuery()));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMedia(int id)
        {
            return Ok(await _mediatR.Send(new GetSocialMediaByIdQuery(id)));

        }
        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommand createSocialMediaCommand)
        {
            await _mediatR.Send(createSocialMediaCommand);
            return Ok("Sosyal Medya Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommand updateSocialMediaCommand)
        {
            await _mediatR.Send(updateSocialMediaCommand);
            return Ok("Sosyal Medya Güncellendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSocialMedia(int id)
        {
            await _mediatR.Send(new RemoveSocialMediaCommand(id));
            return Ok("Sosyal Medya silindi");
        }

    }
}
