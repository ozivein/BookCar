using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
    {
        private readonly ICarPricingRepository _carPricingRepository;
        private readonly IMapper _mapper;
        public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository carPricingRepository, IMapper mapper)
        {
            _carPricingRepository = carPricingRepository;
            _mapper = mapper;
        }

        public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetCarPricingWithTimePeriodQueryResult>>(await _carPricingRepository.GetCarPricingWithTimePeriod());

        }
    }
}
