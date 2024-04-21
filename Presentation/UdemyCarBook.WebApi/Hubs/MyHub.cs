using Microsoft.AspNetCore.SignalR;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.WebApi.Hubs
{
    public class MyHub : Hub
    {
        private readonly IStatisticRepository _statisticRepository;

        public MyHub(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task SendStatisticCarCount()
        {
            var carCount = await _statisticRepository.GetCarCount();
            await Clients.All.SendAsync("ReceiveCarCount", carCount);
        }
        public async Task SendStatisticLokasyonCount()
        {
            var lokasyonCount = await _statisticRepository.GetLocationCount();
            await Clients.All.SendAsync("ReceiveLokasyonCount", lokasyonCount);
        }
        public async Task SendStatisticAuthorCount()
        {
            var authorCount = await _statisticRepository.GetAuthorCount();
            await Clients.All.SendAsync("ReceiveAuthorCount", authorCount);
        }
        public async Task SendStatisticBlogCount()
        {
            var blogCount = await _statisticRepository.GetBlogCount();
            await Clients.All.SendAsync("ReceiveBlogCount", blogCount);
        }
        public async Task SendStatisticBrandCount()
        {
            var brandCount = await _statisticRepository.GetBrandCount();
            await Clients.All.SendAsync("ReceiveBrandCount", brandCount);
        }
        public async Task SendStatisticDailiyCarPricingAvgPrice()
        {
            var getDailiyCarPricingAvgPrice = await _statisticRepository.GetDailiyCarPricingAvgPrice();
            await Clients.All.SendAsync("ReceiveGetDailiyCarPricingAvgPrice", getDailiyCarPricingAvgPrice.ToString("₺ 0.00"));
        }
        public async Task SendStatisticWeeklyCarPricingAvgPrice()
        {
            var getWeeklyCarPricingAvgPrice = await _statisticRepository.GetWeeklyCarPricingAvgPrice();
            await Clients.All.SendAsync("ReceiveGetWeeklyCarPricingAvgPrice", getWeeklyCarPricingAvgPrice.ToString("₺ 0.00"));
        }
        public async Task SendStatisticMountlyCarPricingAvgPrice()
        {
            var getMountlyCarPricingAvgPrice = await _statisticRepository.GetMountlyCarPricingAvgPrice();
            await Clients.All.SendAsync("ReceiveGetMountlyCarPricingAvgPrice", getMountlyCarPricingAvgPrice.ToString("₺ 0.00"));
        }
        public async Task SendStatisticCarCountByTransmissonAuto()
        {
            var getCarCountByTransmissonAuto = await _statisticRepository.GetCarCountByTransmissonAuto();
            await Clients.All.SendAsync("ReceiveGetCarCountByTransmissonAuto", getCarCountByTransmissonAuto);
        }
        public async Task SendStatisticBrandNameByMaxCar()
        {
            var getBrandNameByMaxCar = await _statisticRepository.GetBrandNameByMaxCar();
            await Clients.All.SendAsync("ReceiveGetBrandNameByMaxCar", getBrandNameByMaxCar);
        }
        public async Task SendStatisticTitleByMaxBlogComment()
        {
            var getTitleByMaxBlogComment = await _statisticRepository.GetTitleByMaxBlogComment();
            await Clients.All.SendAsync("ReceiveGetTitleByMaxBlogComment", getTitleByMaxBlogComment);
        }
        public async Task SendStatisticCarCountByKmSmallerThen1000()
        {
            var getCarCountByKmSmallerThen1000 = await _statisticRepository.GetCarCountByKmSmallerThen1000();
            await Clients.All.SendAsync("ReceiveGetCarCountByKmSmallerThen1000", getCarCountByKmSmallerThen1000);
        }
        public async Task SendStatisticCarCountByFuelGassolineOrDiesel()
        {
            var getCarCountByFuelGassolineOrDiesel = await _statisticRepository.GetCarCountByFuelGassolineOrDiesel();
            await Clients.All.SendAsync("ReceiveGetCarCountByFuelGassolineOrDiesel", getCarCountByFuelGassolineOrDiesel);
        }
        public async Task SendStatisticCarCountByFuelElectic()
        {
            var getCarCountByFuelElectic = await _statisticRepository.GetCarCountByFuelElectic();
            await Clients.All.SendAsync("ReceiveGetCarCountByFuelElectic", getCarCountByFuelElectic);

        }
        public async Task SendStatisticCarBrandAndModelByRentPriceDailyMin()
        {

            var getCarBrandAndModelByRentPriceDailyMin = await _statisticRepository.GetCarBrandAndModelByRentPriceDailyMin();
            await Clients.All.SendAsync("ReceiveGetCarBrandAndModelByRentPriceDailyMin", getCarBrandAndModelByRentPriceDailyMin);
        }
        public async Task SendStatisticCarBrandAndModelByRentPriceDailyMax()
        {
            var getCarBrandAndModelByRentPriceDailyMax = await _statisticRepository.GetCarBrandAndModelByRentPriceDailyMax();
            await Clients.All.SendAsync("ReceiveGetCarBrandAndModelByRentPriceDailyMax", getCarBrandAndModelByRentPriceDailyMax);
        }


    }
}

