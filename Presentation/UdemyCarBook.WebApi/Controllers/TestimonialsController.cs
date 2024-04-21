using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public TestimonialsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }


        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {
            return Ok(await _mediatR.Send(new GetTestimonialQuery()));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            return Ok(await _mediatR.Send(new GetTestimonialByIdQuery(id)));
        }
        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommand createTestimonialCommand)
        {
            await _mediatR.Send(createTestimonialCommand);
            return Ok("Referans Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialCommand updateTestimonialCommand)
        {
            await _mediatR.Send(updateTestimonialCommand);
            return Ok("Referans Güncellendi");
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> RemoveTestimonial(int id)
        {
            await _mediatR.Send(new RemoveTestimonialCommand(id));
            return Ok("Referans Silindi");
        }
    }
}
