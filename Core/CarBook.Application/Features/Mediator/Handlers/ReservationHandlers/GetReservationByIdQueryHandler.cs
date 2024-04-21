using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results.ReservationResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class GetReservationByIdQueryHandler : IRequestHandler<GetReservationByIdQuery, GetReservationByIdQueryResult>
    {
        private readonly IRepository<Reservation> _reservation;
        private readonly IMapper _mapper;

        public GetReservationByIdQueryHandler(IRepository<Reservation> reservation, IMapper mapper)
        {
            _reservation = reservation;
            _mapper = mapper;
        }
        public async Task<GetReservationByIdQueryResult> Handle(GetReservationByIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetReservationByIdQueryResult>(await _reservation.GetByIdAsync(request.ReservationId));
        }
    }
}
