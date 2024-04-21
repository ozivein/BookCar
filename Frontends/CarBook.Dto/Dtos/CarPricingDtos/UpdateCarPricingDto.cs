namespace UdemyCarBook.Dto.Dtos
{
    public class UpdateCarPricingDto
    {
        public int CarPricingId { get; set; }
        public int CarId { get; set; }
        public int PricingId { get; set; }
        public decimal Amaount { get; set; }
    }
}
