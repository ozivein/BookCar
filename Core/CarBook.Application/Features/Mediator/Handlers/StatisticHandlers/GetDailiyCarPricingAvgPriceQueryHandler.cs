using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetDailiyCarPricingAvgPriceQueryHandler : IRequestHandler<GetDailiyCarPricingAvgPriceQuery, GetDailiyCarPricingAvgPriceQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetDailiyCarPricingAvgPriceQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetDailiyCarPricingAvgPriceQueryResult> Handle(GetDailiyCarPricingAvgPriceQuery request, CancellationToken cancellationToken)
        {
            return new GetDailiyCarPricingAvgPriceQueryResult { DailyAmount = await _statisticRepository.GetDailiyCarPricingAvgPrice() };
        }
    }
}
