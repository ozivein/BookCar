using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveReservationCommand:IRequest
    {
        public int ReservationId { get; set; }

        public RemoveReservationCommand(int reservationId)
        {
            ReservationId = reservationId;
        }
    }
}
