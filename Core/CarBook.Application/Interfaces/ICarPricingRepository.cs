using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface ICarPricingRepository
    {
        Task<List<CarPricing>> GetCarWithPricingAndBrandList();
        Task<List<CarPricing>> GetCarWithPricingAndBrandDayList();
        Task<List<CarPricingViewModel>> GetCarPricingWithTimePeriod();
    }
}
