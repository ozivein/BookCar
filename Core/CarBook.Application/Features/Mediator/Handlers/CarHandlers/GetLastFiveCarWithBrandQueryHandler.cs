using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarHandlers
{
    public class GetLastFiveCarWithBrandQueryHandler : IRequestHandler<GetLastFiveCarWithBrandQuery, List<GetLastFiveCarWithBrandQueryResult>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public GetLastFiveCarWithBrandQueryHandler(ICarRepository carRepository, IMapper mapper)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<List<GetLastFiveCarWithBrandQueryResult>> Handle(GetLastFiveCarWithBrandQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetLastFiveCarWithBrandQueryResult>>(await _carRepository.GetLastFiveCarWithBrand());

        }
    }
}
