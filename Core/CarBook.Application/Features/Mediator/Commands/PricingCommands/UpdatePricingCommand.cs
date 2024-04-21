using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdatePricingCommand:IRequest
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
    }
}
