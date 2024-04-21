using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;


namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly IMediator _meditorR;

        public BannersController(IMediator meditorR)
        {
            _meditorR = meditorR;
        }

        [HttpGet]
        public async Task<IActionResult> BannerList()
        {
            var values = await _meditorR.Send(new GetBannerQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBanner(int id)
        {
            var values = await _meditorR.Send(new GetBannerByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerCommand createBannerCommand)
        {
            await _meditorR.Send(createBannerCommand);
            return Ok("Banner bilgisi Eklendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveBanner(int id)
        {
            await _meditorR.Send(new RemoveBannerCommand(id));
            return Ok("Banner bilgisi silindi");
        }

        [HttpPut]
        public async Task<IActionResult> BannerUpdate(UpdateBannerCommand updateBannerCommand)
        {
            await _meditorR.Send(updateBannerCommand);
            return Ok("Banner bilgisi güncellendi");
        }
    }
}
