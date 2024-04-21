namespace UdemyCarBook.Domain.Entities
{
    public class CarPricing
    {
        public int CarPricingId { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int PricingId { get; set; }
        public virtual Pricing Pricing { get; set; }

        public decimal Amaount { get; set; }
    }
}
