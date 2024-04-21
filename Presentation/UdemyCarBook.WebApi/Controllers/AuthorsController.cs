using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public AuthorsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> AuthorList()
        {
            return Ok(await _mediatR.Send(new GetAuthorQuery()));
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetAuthor(int id)
        {
            return Ok(await _mediatR.Send(new GetAuthorByIdQuery(id)));
        }

        [HttpPost]

        public async Task<IActionResult> CreateAuthor(CreateAuthorCommand createAuthorCommand)
        {
            await _mediatR.Send(createAuthorCommand);
            return Ok("Yazar Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommand updateAuthorCommand)
        {
            await _mediatR.Send(updateAuthorCommand);
            return Ok("Yazar güncellendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveAuthor(int id)
        {
            await _mediatR.Send(new RemoveAuthorCommand(id));
            return Ok("Yazar silindi");
        }
    }

}
