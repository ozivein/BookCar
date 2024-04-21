using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public CommentsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> CommentList()
        {
            var values = await _mediatR.Send(new GetCommentQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
            var values = await _mediatR.Send(new GetCommentByIdQuery(id));
            return Ok(values);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetCommentByBlogId(int id)
        {
            var values = await _mediatR.Send(new GetCommentByBlogIdQuery(id));
            return Ok(values);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetBlogCommentCount(int id)
        {
            var values = await _mediatR.Send(new GetCommentBlogCountQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentCommand createCommentCommand)
        {
            await _mediatR.Send(createCommentCommand);
            return Ok("Yorum  Eklendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveComment(int id)
        {
            await _mediatR.Send(new RemoveCommentCommand(id));
            return Ok("Yorum silindi");
        }

        [HttpPut]
        public async Task<IActionResult> CommentUpdate(UpdateCommentCommand updateCommentCommand)
        {
            await _mediatR.Send(updateCommentCommand);
            return Ok("Yorum güncellendi");
        }
    }
}
