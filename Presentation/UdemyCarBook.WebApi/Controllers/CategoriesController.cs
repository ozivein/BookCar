using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public CategoriesController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _mediatR.Send(new GetCategoryQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var values = await _mediatR.Send(new GetCategoryByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand createCategoryCommand)
        {
            await _mediatR.Send(createCategoryCommand);
            return Ok("Kategori bilgisi Eklendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveCategory(int id)
        {
            await _mediatR.Send(new RemoveCategoryCommand(id));
            return Ok("Kategori bilgisi silindi");
        }

        [HttpPut]
        public async Task<IActionResult> CategoryUpdate(UpdateCategoryCommand updateCategoryCommand)
        {
            await _mediatR.Send(updateCategoryCommand);
            return Ok("Kategori bilgisi güncellendi");
        }
    }
}
