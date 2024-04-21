using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public BlogsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> BlogList()
        {
            return Ok(await _mediatR.Send(new GetBlogQuery()));
        }
        [HttpGet("{id}")]

        public async Task<IActionResult> GetBlog(int id)
        {
            return Ok(await _mediatR.Send(new GetBlogByIdQuery(id)));
        }

        [HttpPost]

        public async Task<IActionResult> CreateBlog(CreateBlogCommand createBlogCommand)
        {
            createBlogCommand.CreatedDate = DateTime.Now;
            await _mediatR.Send(createBlogCommand);
            return Ok("Blog Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand updateBlogCommand)
        {
            await _mediatR.Send(updateBlogCommand);
            return Ok("Blog güncellendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveBlog(int id)
        {
            await _mediatR.Send(new RemoveBlogCommand(id));
            return Ok("Blog silindi");
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetBlogWithAuthorAndCategoryList()
        {
            return Ok(await _mediatR.Send(new GetBlogWithAuthorAndCategoryQuery()));
        }
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetBlogWithAuthorList(int id)
        {
            return Ok(await _mediatR.Send(new GetBlogWithAuthorQuery(id)));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetLastThreeBlogsWithAuthorsAndCategory()
        {
            return Ok(await _mediatR.Send(new GetLastThreeBlogsWithAuthorsAndCategoryQuery()));
        }
    }

}
