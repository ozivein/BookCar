using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Controllers
{
    public class CarPricingController : Controller
    {
        private readonly ICarPricingConsumeApiServe _carPricingConsumeApiServe;
        private readonly ISharedAuthorizationApiService _shared;

        public CarPricingController(ICarPricingConsumeApiServe carPricingConsumeApiServe, ISharedAuthorizationApiService shared)
        {
            _carPricingConsumeApiServe = carPricingConsumeApiServe;
            _shared = shared;
        }

        public  async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Paketler";
            ViewBag.v2 = "Araç Fiyat Paketleri";

            return View(await _carPricingConsumeApiServe.GetCarPricingWithTimePeriod(_shared.AccessToken));
        }
       

    }
}
