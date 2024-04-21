namespace UdemyCarBook.Dto.Dtos
{
    public class GetCarPricingWithTimePeriodDto
    {

        public string ModelBrand { get; set; }
        public decimal DailyAmound { get; set; }
        public decimal WeeklyAmount { get; set; }
        public decimal MountlyAmoun { get; set; }
        public string CoverImageUrl { get; set; }


    }
}
