using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveLocationCommand:IRequest
    {
        public int LocationId { get; set; }

        public RemoveLocationCommand(int locationId)
        {
            LocationId = locationId;
        }
    }
}
