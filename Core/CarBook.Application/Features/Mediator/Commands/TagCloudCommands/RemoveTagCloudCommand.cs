using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveTagCloudCommand:IRequest
    {
        public int TagCloudId { get; set; }

        public RemoveTagCloudCommand(int tagCloudId)
        {
            TagCloudId = tagCloudId;
        }
    }
}
