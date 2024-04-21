using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AdminAuthorController : Controller
    {
        private readonly IAuthorConsumeApiService _AuthorConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminAuthorController(IAuthorConsumeApiService AuthorConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _AuthorConsumeApiService = AuthorConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminAuthorController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _AuthorConsumeApiService.GetListAsync("Authors", _shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.AuthorId.ToString()));
            return View(values);
        }

        public IActionResult CreateAuthor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorDto createAuthorDto)
        {
            var response = await _AuthorConsumeApiService.CreateAsync("Authors", createAuthorDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _AuthorConsumeApiService.GetByIdUpdateAsync("Authors", dataValue, _shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateAuthorDto updateAuthorDto)
        {
            var response = await _AuthorConsumeApiService.UpdateAsync("Authors", updateAuthorDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _AuthorConsumeApiService.RemoveAsync("Authors", dataValue, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
