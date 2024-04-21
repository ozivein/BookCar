using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
    {
        private readonly IRepository<Reservation> _reservation;
        private readonly IMapper _mapper;

        public CreateReservationCommandHandler(IRepository<Reservation> reservation, IMapper mapper)
        {
            _reservation = reservation;
            _mapper = mapper;
        }

        public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            request.Status = "Rezervasyon Alındı";
            await _reservation.CreateAsync(_mapper.Map<Reservation>(request));
        }
    }
}
