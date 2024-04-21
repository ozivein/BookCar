using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.RenACarHandlers
{
    public class GetRentACarFilterQeuryHandler : IRequestHandler<GetRentACarFilterQeury, List<GetRentACarFilterQeuryResult>>
    {
        private readonly IRentACarRepository _rentACarRepository;
        private readonly IMapper _mapper;
        public GetRentACarFilterQeuryHandler(IRentACarRepository rentACarRepository, IMapper mapper)
        {
            _rentACarRepository = rentACarRepository;
            _mapper = mapper;
        }

        public async Task<List<GetRentACarFilterQeuryResult>> Handle(GetRentACarFilterQeury request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetRentACarFilterQeuryResult>>(await _rentACarRepository.GetFilterRenACar(x => x.LocationId == request.LocationId && x.Available == request.Available));
        }
    }
}
