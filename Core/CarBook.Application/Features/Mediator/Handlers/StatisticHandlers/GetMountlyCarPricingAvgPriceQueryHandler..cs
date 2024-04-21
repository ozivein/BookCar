using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetMountlyCarPricingAvgPriceQueryHandler : IRequestHandler<GetMountlyCarPricingAvgPriceQuery, GetMountlyCarPricingAvgPriceQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetMountlyCarPricingAvgPriceQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetMountlyCarPricingAvgPriceQueryResult> Handle(GetMountlyCarPricingAvgPriceQuery request, CancellationToken cancellationToken)
        {
            return new GetMountlyCarPricingAvgPriceQueryResult { MonthlyAmount = await _statisticRepository.GetMountlyCarPricingAvgPrice() };
        }
    }
}
