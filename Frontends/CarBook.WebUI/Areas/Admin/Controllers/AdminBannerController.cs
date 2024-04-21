using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]

    public class AdminBannerController : Controller
    {
        private readonly IBannerConsumeApiService _BannerConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminBannerController(IBannerConsumeApiService BannerConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _BannerConsumeApiService = BannerConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminBannerController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _BannerConsumeApiService.GetListAsync("Banners", _shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.BannerId.ToString()));
            return View(values);
        }

        public IActionResult CreateBanner()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto createBannerDto)
        {
            var response = await _BannerConsumeApiService.CreateAsync("Banners", createBannerDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _BannerConsumeApiService.GetByIdUpdateAsync("Banners", dataValue, _shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateBannerDto updateBannerDto)
        {
            var response = await _BannerConsumeApiService.UpdateAsync("Banners", updateBannerDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _BannerConsumeApiService.RemoveAsync("Banners", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
