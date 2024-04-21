using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateLocationCommand:IRequest
    {
        public string Name { get; set; }
    }
}
