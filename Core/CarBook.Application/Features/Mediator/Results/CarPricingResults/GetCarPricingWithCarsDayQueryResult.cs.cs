using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetCarPricingWithCarsDayQueryResult
    {
        public int CarPricingId { get; set; }
        public int CarId { get; set; }
        public string CarModel { get; set; }
        public string CoverImageUrl { get; set; }
        public string Km { get; set; }
        public string BrandName { get; set; }
        public int PricingId { get; set; }
        public string PricingName { get; set; }
        public decimal Amaount { get; set; }
    }
}
