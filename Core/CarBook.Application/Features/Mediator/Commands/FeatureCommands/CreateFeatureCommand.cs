using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateFeatureCommand:IRequest
    {
        public string Name { get; set; }
    }
}
