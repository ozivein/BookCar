using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
        private readonly IStatisticConsumeApiService _statisticConsumeApiService;

        public _DefaultStatisticComponentPartial(IStatisticConsumeApiService statisticConsumeApiService)
        {
            _statisticConsumeApiService = statisticConsumeApiService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var carCount = await _statisticConsumeApiService.GetStatisticCount("Statistics", "GetCountCar");
            ViewBag.CarCount = carCount.CarCount;
            var locationCount = await _statisticConsumeApiService.GetStatisticCount("Statistics", "GetCountLocation");
            ViewBag.LocationCount = locationCount.LocationCount;
            var carCountByFuelElecticCount = await _statisticConsumeApiService.GetStatisticCount("Statistics", "GetCarCountByFuelElectic");
            ViewBag.CarCountByFuelElecticCount = carCountByFuelElecticCount.Count;
            var brandCount = await _statisticConsumeApiService.GetStatisticCount("Statistics", "GetBrandCar");
            ViewBag.BrandCount = brandCount.BrandCount;
            return View();
        }
    }
}
