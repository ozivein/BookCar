using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReviewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{carId}")]
        public async Task<IActionResult> GetReviewListByCarId(int carId)
        {
            return Ok(await _mediator.Send(new GetReviewListByCarIdQuery(carId)));
        }
        [HttpPost]
        public async Task<IActionResult> CreateReview(CreateReviewCommand createReviewCommand)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.Select(x => x.Value));
            await _mediator.Send(createReviewCommand);
            return Ok("Yorum Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReview(UpdateReviewCommand updateReviewCommand)
        {
            await _mediator.Send(updateReviewCommand);
            return Ok("Yorum Güncellendi");
        }
    }
}
