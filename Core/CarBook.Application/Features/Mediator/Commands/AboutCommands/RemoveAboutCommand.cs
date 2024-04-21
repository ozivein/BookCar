using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveAboutCommand : IRequest
    {
        public int AboutId { get; set; }
        public RemoveAboutCommand(int aboutId)
        {
            AboutId = aboutId;
        }
    }
}
