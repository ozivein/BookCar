using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class GetReservationQueryHandler : IRequestHandler<GetReservationQuery, List<GetReservationQueryResults>>
    {
        private readonly IReservationRepository _reservation;
        private readonly IMapper _mapper;

        public GetReservationQueryHandler(IReservationRepository reservation, IMapper mapper)
        {
            _reservation = reservation;
            _mapper = mapper;
        }
        public async Task<List<GetReservationQueryResults>> Handle(GetReservationQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetReservationQueryResults>>(await _reservation.GetReservationWithCarAndLocationList());
        }
    }
}
