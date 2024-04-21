using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetCarCountByTransmissonAutoQueryHandler : IRequestHandler<GetCarCountByTransmissonAutoQuery, GetCarCountByTransmissonAutoQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetCarCountByTransmissonAutoQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetCarCountByTransmissonAutoQueryResult> Handle(GetCarCountByTransmissonAutoQuery request, CancellationToken cancellationToken)
        {
            return new GetCarCountByTransmissonAutoQueryResult { Count = await _statisticRepository.GetCarCountByTransmissonAuto() };
        }
    }
}
