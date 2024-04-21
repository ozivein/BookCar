using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveTestimonialCommand:IRequest
    {
        public int TestimonialId { get; set; }

        public RemoveTestimonialCommand(int testimonialId)
        {
            TestimonialId = testimonialId;
        }
    }
}
