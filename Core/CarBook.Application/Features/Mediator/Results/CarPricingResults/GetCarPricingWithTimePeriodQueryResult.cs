namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetCarPricingWithTimePeriodQueryResult
    {
        public string ModelBrand { get; set; }
        public decimal DailyAmound {  get; set; }
        public decimal WeeklyAmount { get; set; }
        public decimal MountlyAmoun { get; set; }
        public string CoverImageUrl { get; set; }


    }
}
