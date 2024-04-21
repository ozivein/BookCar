using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]

    public class AdminFeatureController : Controller
    {
        private readonly IFeatureConsumeApiService _featureConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminFeatureController(IFeatureConsumeApiService featureConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _featureConsumeApiService = featureConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminFeatureController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _featureConsumeApiService.GetListAsync("Features", _shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.FeatureId.ToString()));
            return View(values);
        }

        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var response = await _featureConsumeApiService.CreateAsync("Features", createFeatureDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _featureConsumeApiService.GetByIdUpdateAsync("Features", dataValue, _shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateFeatureDto updateFeatureDto)
        {
            var response = await _featureConsumeApiService.UpdateAsync("Features", updateFeatureDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _featureConsumeApiService.RemoveAsync("Features", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
