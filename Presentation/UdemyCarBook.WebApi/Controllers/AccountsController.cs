using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Tools;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public AccountsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }
        [HttpPost]
        public async Task<IActionResult> Login(GetCheckApUserQuery getCheckApUserQuery)
        {
            var values = await _mediatR.Send(getCheckApUserQuery);

            if (values.IsExist)
            {
                return Created("", JwtTokenGenerator.GenerateToken(values));
            }
            return BadRequest("Kullanıcı Adı veya Şifre Hatalıdır");
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateAppUser(CreateAppUserCommand createAppUserCommand)
        {
            await _mediatR.Send(createAppUserCommand);
            return Ok("Kulanıcı Başarıyla Oluşturuldu");
        }
    }
}
