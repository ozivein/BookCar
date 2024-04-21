using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminLocationController : Controller
    {
        private readonly ILocationConsumeApiService _LocationConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminLocationController(ILocationConsumeApiService LocationConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _LocationConsumeApiService = LocationConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminLocationController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {

            var values = await _LocationConsumeApiService.GetListAsync("Locations", _shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.LocationId.ToString()));
            return View(values);
        }

        public IActionResult CreateLocation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateLocation(CreateLocationDto createLocationDto)
        {
            var response = await _LocationConsumeApiService.CreateAsync("Locations", createLocationDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _LocationConsumeApiService.GetByIdUpdateAsync("Locations", dataValue, _shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateLocationDto updateLocationDto)
        {
            var response = await _LocationConsumeApiService.UpdateAsync("Locations", updateLocationDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _LocationConsumeApiService.RemoveAsync("Locations", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
