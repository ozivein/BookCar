using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetRentACarFilterQeury : IRequest<List<GetRentACarFilterQeuryResult>>
    {
        public int LocationId { get; set; }
        public bool Available { get; set; }

        public GetRentACarFilterQeury(int locationId, bool available)
        {
            LocationId = locationId;
            Available = available;
        }
    }
}
