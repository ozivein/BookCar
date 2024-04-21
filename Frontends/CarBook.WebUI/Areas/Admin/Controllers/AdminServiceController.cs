using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AdminServiceController : Controller
    {
        private readonly IServiceConsumeApiService _ServiceConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminServiceController(IServiceConsumeApiService ServiceConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _ServiceConsumeApiService = ServiceConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminServiceController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _ServiceConsumeApiService.GetListAsync("Services", _shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.ServiceId.ToString()));
            return View(values);
        }
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            var response = await _ServiceConsumeApiService.CreateAsync("Services", createServiceDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _ServiceConsumeApiService.GetByIdUpdateAsync("Services", dataValue, _shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateServiceDto updateServiceDto)
        {
            var response = await _ServiceConsumeApiService.UpdateAsync("Services", updateServiceDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _ServiceConsumeApiService.RemoveAsync("Services", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
