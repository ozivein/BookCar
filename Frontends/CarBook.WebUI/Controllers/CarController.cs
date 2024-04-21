using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarPricingConsumeApiServe _carService;
        private readonly IDataProtector _dataProtector;
        public CarController(ICarPricingConsumeApiServe carService, IDataProtectionProvider dataProtector)
        {
            _carService = carService;
            _dataProtector = dataProtector.CreateProtector("CarController");
        }
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Araçlarımız";
            ViewBag.v2 = "Aracınızı Seçiniz";
            var values = await _carService.GetListAsync("CarPricings", "CarPricingWithCarsDayList");
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.CarId.ToString()));
            return View(values);
        }
        [HttpGet]
        public IActionResult CarDetail(string id)
        {
            ViewBag.DataProtectCarId = id;
            ViewBag.v1 = "Araç Detayları";
            ViewBag.v2 = "Aracın Teknik Aksesuar ve Özellikleri";
            return View();
        }
    }
}
