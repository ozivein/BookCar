using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Controllers
{
    public class RentACarController : Controller
    {
        private readonly IRentACarConsumeApiService _rentaCarConsumeApiService;
        private readonly IDataProtector _dataProtector;
        public RentACarController(IRentACarConsumeApiService rentaCarConsumeApiService, IDataProtectionProvider dataProtector)
        {
            _rentaCarConsumeApiService = rentaCarConsumeApiService;
            _dataProtector = dataProtector.CreateProtector("RentACarController");
        }

        public async Task<IActionResult> Index()
        {
            var locationData = JsonSerializer.Deserialize<ResultRentAcarLocationFilterDto>(TempData["Result"].ToString());
            var response = await _rentaCarConsumeApiService.GetRentACarFilter(locationData.LocationId, true);
            response.ForEach(x => x.DataProtect = _dataProtector.Protect(x.CarId.ToString()));
            return View(response);
        }
        
    }
}
