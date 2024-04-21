using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateTestimonialCommand:IRequest
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
