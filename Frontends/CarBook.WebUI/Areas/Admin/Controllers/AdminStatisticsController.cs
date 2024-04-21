using Microsoft.AspNetCore.Mvc;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminStatisticsController : Controller
    {
        public IActionResult Index()
        {
            Random rnd = new Random();
            ViewBag.carCountRandom = rnd.Next(0, 101);
            ViewBag.locationCountRandom= rnd.Next(0, 101);
            ViewBag.authorCountRandom= rnd.Next(0, 101);
            ViewBag.blogCountRandom= rnd.Next(0, 101);
            ViewBag.brandCountRandom= rnd.Next(0, 101);
            ViewBag.getDailiyCarPricingAvgPriceRandom= rnd.Next(0, 101);

            ViewBag.getWeeklyCarPricingAvgPriceRandom= rnd.Next(0, 101);
            ViewBag.getMountlyCarPricingAvgPriceRondom = rnd.Next(0, 101);
            ViewBag.getCarCountByTransmissonAutoRandom = rnd.Next(0, 101);
            ViewBag.getBrandNameByMaxCarRandom = rnd.Next(0, 101);
            ViewBag.getTitleByMaxBlogCommentRandom = rnd.Next(0, 101);
            ViewBag.getCarCountByKmSmallerThen1000Random = rnd.Next(0, 101);
            ViewBag.getCarCountByFuelGassolineOrDieselRandom = rnd.Next(0, 101);
            ViewBag.getCarCountByFuelElecticRandom = rnd.Next(0, 101);
            ViewBag.getCarBrandAndModelByRentPriceDailyMinRandom = rnd.Next(0, 101);
            ViewBag.getCarBrandAndModelByRentPriceDailyMaxRandom = rnd.Next(0, 101);
            return View();
        }
    }
}
