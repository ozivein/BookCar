using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreatePricingCommand:IRequest
    {
        public string Name { get; set; }
    }
}
