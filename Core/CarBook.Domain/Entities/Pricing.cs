namespace UdemyCarBook.Domain.Entities
{
    public class Pricing
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
        public virtual List<CarPricing> CarPricings { get; set; }
    }
}
