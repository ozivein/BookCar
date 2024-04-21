using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminPricingController : Controller
    {
        private readonly IPricingConsumeApiService _PricingConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminPricingController(IPricingConsumeApiService PricingConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _PricingConsumeApiService = PricingConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminPricingController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _PricingConsumeApiService.GetListAsync("Pricings", _shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.PricingId.ToString()));
            return View(values);
        }

        public IActionResult CreatePricing()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatePricingDto createPricingDto)
        {
            var response = await _PricingConsumeApiService.CreateAsync("Pricings", createPricingDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _PricingConsumeApiService.GetByIdUpdateAsync("Pricings", dataValue,_shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdatePricingDto updatePricingDto)
        {
            var response = await _PricingConsumeApiService.UpdateAsync("Pricings", updatePricingDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _PricingConsumeApiService.RemoveAsync("Pricings", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
