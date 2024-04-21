namespace UdemyCarBook.Application.ViewModels
{
    public class CarPricingViewModel
    {
        public CarPricingViewModel()
        {

            Amounts = new List<decimal>();
        }
        public string ModelBrand { get; set; }

        public string CoverImageUrl { get; set; }
        public List<decimal> Amounts { get; set; }
    }
}
