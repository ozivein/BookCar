using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateCarPricingCommand : IRequest
    {
        public int CarId { get; set; }
        public int PricingId { get; set; }

        public decimal Amaount { get; set; }
    }
}
