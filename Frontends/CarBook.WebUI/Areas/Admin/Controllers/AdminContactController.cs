using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[Controller]/[Action]")]
    public class AdminContactController : Controller
    {
        private readonly IContactConsumeApiService _ContactConsumeApiService;
        private readonly IDataProtector _dataProtect;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminContactController(IContactConsumeApiService ContactConsumeApiService, IDataProtectionProvider dataProtect, ISharedAuthorizationApiService shared)
        {
            _ContactConsumeApiService = ContactConsumeApiService;
            _dataProtect = dataProtect.CreateProtector("AdminContactController");
            _shared = shared;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _ContactConsumeApiService.GetListAsync("Contacts", _shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtect.Protect(x.ContactId.ToString()));
            return View(values);
        }

        public async Task<IActionResult> Update(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            return View(await _ContactConsumeApiService.GetByIdUpdateAsync("Contacts", dataValue, _shared.AccessToken));
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateContactDto updateContactDto)
        {
            var response = await _ContactConsumeApiService.UpdateAsync("Contacts", updateContactDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var dataValue = int.Parse(_dataProtect.Unprotect(id));
            var response = await _ContactConsumeApiService.RemoveAsync("Contacts", dataValue, _shared.AccessToken );
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
