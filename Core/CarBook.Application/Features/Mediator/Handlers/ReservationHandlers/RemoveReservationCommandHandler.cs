using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class RemoveReservationCommandHandler : IRequestHandler<RemoveReservationCommand>
    {
        private readonly IRepository<Reservation> _reservation;

        public RemoveReservationCommandHandler(IRepository<Reservation> reservation)
        {
            _reservation = reservation;
        }

        public async Task Handle(RemoveReservationCommand request, CancellationToken cancellationToken)
        {
             await _reservation.DeleteAsync(await _reservation.GetByIdAsync(request.ReservationId));
        }
    }
}
