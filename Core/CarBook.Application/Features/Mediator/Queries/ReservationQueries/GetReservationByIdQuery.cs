using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results.ReservationResults;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetReservationByIdQuery:IRequest<GetReservationByIdQueryResult>
    {
        public int ReservationId { get; set; }

        public GetReservationByIdQuery(int reservationId)
        {
            ReservationId = reservationId;
        }
    }
}
