namespace UdemyCarBook.Application.Interfaces
{
    public interface IStatisticRepository
    {
        Task<int> GetCarCount();
        Task<int> GetLocationCount();
        Task<int> GetAuthorCount();
        Task<int> GetBlogCount();
        Task<int> GetBrandCount();
        Task<decimal> GetDailiyCarPricingAvgPrice();
        Task<decimal> GetWeeklyCarPricingAvgPrice();
        Task<decimal> GetMountlyCarPricingAvgPrice();
        Task<int> GetCarCountByTransmissonAuto();
        Task<string> GetBrandNameByMaxCar();
        Task<string> GetTitleByMaxBlogComment();
        Task<int> GetCarCountByKmSmallerThen1000();
        Task<int> GetCarCountByFuelGassolineOrDiesel();
        Task<int> GetCarCountByFuelElectic();
        Task<string> GetCarBrandAndModelByRentPriceDailyMin();
        Task<string> GetCarBrandAndModelByRentPriceDailyMax();



    }
}
