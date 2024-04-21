using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetReviewListByCarIdQuery:IRequest<List<GetReviewListByCarIdQueryResult>>
    {
        public int CarId { get; set; }

        public GetReviewListByCarIdQuery(int carId)
        {
            CarId = carId;
        }
    }
}
