using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetCarCountByFuelElecticQueryHandler : IRequestHandler<GetCarCountByFuelElecticQuery, GetCarCountByFuelElecticQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetCarCountByFuelElecticQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetCarCountByFuelElecticQueryResult> Handle(GetCarCountByFuelElecticQuery request, CancellationToken cancellationToken)
        {
            return new GetCarCountByFuelElecticQueryResult { Count = await _statisticRepository.GetCarCountByFuelElectic() };
        }
    }
}
