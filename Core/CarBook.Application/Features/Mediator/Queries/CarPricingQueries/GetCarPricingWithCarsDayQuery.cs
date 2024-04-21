using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetCarPricingWithCarsDayQuery : IRequest<List<GetCarPricingWithCarsDayQueryResult>>
    {
    }
}
