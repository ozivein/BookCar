using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateCarPricingCommand:IRequest
    {
        public int CarPricingId { get; set; }
        public int CarId { get; set; }
        public int PricingId { get; set; }

        public decimal Amaount { get; set; }
    }
}
