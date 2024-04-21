using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemovePricingCommand : IRequest
    {
        public int PricingId { get; set; }

        public RemovePricingCommand(int pricingId)
        {
            PricingId = pricingId;
        }
    }
}
