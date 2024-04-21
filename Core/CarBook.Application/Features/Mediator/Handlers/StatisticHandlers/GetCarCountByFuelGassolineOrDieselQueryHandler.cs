using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetCarCountByFuelGassolineOrDieselQueryHandler : IRequestHandler<GetCarCountByFuelGassolineOrDieselQuery, GetCarCountByFuelGassolineOrDieselQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetCarCountByFuelGassolineOrDieselQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetCarCountByFuelGassolineOrDieselQueryResult> Handle(GetCarCountByFuelGassolineOrDieselQuery request, CancellationToken cancellationToken)
        {
            return new GetCarCountByFuelGassolineOrDieselQueryResult { Count = await _statisticRepository.GetCarCountByFuelGassolineOrDiesel() };
        }
    }
}
