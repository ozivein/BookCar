using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand>
    {
        private readonly IRepository<Reservation> _reservation;
        private readonly IMapper _mapper;

        public UpdateReservationCommandHandler(IRepository<Reservation> reservation, IMapper mapper)
        {
            _reservation = reservation;
            _mapper = mapper;
        }
        public async Task Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            await _reservation.UpdateAsync(_mapper.Map<Reservation>(request));
        }
    }
}
