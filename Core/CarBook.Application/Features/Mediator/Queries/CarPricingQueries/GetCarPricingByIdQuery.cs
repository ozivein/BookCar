using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetCarPricingByIdQuery:IRequest<GetCarPricingByIdQueryResult>
    {
        public int CarPricingId { get; set; }

        public GetCarPricingByIdQuery(int carPricingId)
        {
            CarPricingId = carPricingId;
        }
    }
}
