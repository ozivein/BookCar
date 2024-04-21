using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetTestimonialByIdQuery:IRequest<GetTestimonialByIdQueryResult>
    {
        public int TestimonialId { get; set; }

        public GetTestimonialByIdQuery(int testimonialId)
        {
            TestimonialId = testimonialId;
        }
    }
}
