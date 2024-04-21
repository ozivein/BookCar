using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateServiceCommand:IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}
