using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveServiceCommand:IRequest
    {
        public int ServiceId { get; set; }

        public RemoveServiceCommand(int serviceId)
        {
            ServiceId = serviceId;
        }
    }
}
