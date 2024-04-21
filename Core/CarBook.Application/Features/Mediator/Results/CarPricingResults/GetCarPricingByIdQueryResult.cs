using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetCarPricingByIdQueryResult
    {
        public int CarPricingId { get; set; }
        public int CarId { get; set; }
        public int PricingId { get; set; }
        public decimal Amaount { get; set; }
    }
}
