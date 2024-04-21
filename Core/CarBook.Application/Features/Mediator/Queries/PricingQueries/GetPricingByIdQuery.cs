using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetPricingByIdQuery:IRequest<GetPricingByIdQueryResult>
    {
        public int PricingId { get; set; }

        public GetPricingByIdQuery(int pricingId)
        {
            PricingId = pricingId;
        }
    }
}
