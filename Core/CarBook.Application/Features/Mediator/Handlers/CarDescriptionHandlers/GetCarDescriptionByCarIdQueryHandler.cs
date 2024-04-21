using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.CarDescrpitonQueries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers
{
    public class GetCarDescriptionByCarIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionByCarIdQueryResult>
    {
        private readonly ICarDescriptionRepository _carDescriptionRepository;
        private readonly IMapper _mapper;
        public GetCarDescriptionByCarIdQueryHandler(ICarDescriptionRepository carDescriptionRepository, IMapper mapper)
        {
            _carDescriptionRepository = carDescriptionRepository;
            _mapper = mapper;
        }

        public async Task<GetCarDescriptionByCarIdQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetCarDescriptionByCarIdQueryResult>(await _carDescriptionRepository.GetCarDescrpitonByCarIdAsync(request.CarId));
        }
    }
}
