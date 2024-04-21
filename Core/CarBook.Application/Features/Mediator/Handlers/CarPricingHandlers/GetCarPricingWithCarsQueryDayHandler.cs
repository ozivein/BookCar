using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class GetCarPricingWithCarsQueryDayHandler : IRequestHandler<GetCarPricingWithCarsDayQuery, List<GetCarPricingWithCarsDayQueryResult>>
    {
        private readonly ICarPricingRepository _repository;
        private readonly IMapper _mapper;
        public GetCarPricingWithCarsQueryDayHandler(ICarPricingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCarPricingWithCarsDayQueryResult>> Handle(GetCarPricingWithCarsDayQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetCarPricingWithCarsDayQueryResult>>(await _repository.GetCarWithPricingAndBrandDayList());
        }

    }
}
