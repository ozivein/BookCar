using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveCarCommand:IRequest
    {
        public int CarId { get; set; }

        public RemoveCarCommand(int carId)
        {
            CarId = carId;
        }
    }
}
