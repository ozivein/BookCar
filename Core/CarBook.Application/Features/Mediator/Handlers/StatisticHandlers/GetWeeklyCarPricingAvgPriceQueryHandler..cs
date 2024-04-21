using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetWeeklyCarPricingAvgPriceQueryHandler : IRequestHandler<GetWeeklyCarPricingAvgPriceQuery, GetWeeklyCarPricingAvgPriceQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetWeeklyCarPricingAvgPriceQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetWeeklyCarPricingAvgPriceQueryResult> Handle(GetWeeklyCarPricingAvgPriceQuery request, CancellationToken cancellationToken)
        {
            return new GetWeeklyCarPricingAvgPriceQueryResult { WeeklyAmount = await _statisticRepository.GetWeeklyCarPricingAvgPrice() };
        }
    }
}
