using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveCarPricingCommand:IRequest
    {
        public int CarPricingId { get; set; }

        public RemoveCarPricingCommand(int carPricingId)
        {
            CarPricingId = carPricingId;
        }
    }
}
