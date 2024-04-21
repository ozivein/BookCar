using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactConsumeApiService _contactConsumeApiService;
        private readonly ISharedAuthorizationApiService _shared;
        public ContactController(IContactConsumeApiService contactConsumeApiService, ISharedAuthorizationApiService shared)
        {
            _contactConsumeApiService = contactConsumeApiService;
            _shared = shared;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto)
        {
            var response = await _contactConsumeApiService.CreateAsync("Contacts", createContactDto, _shared.AccessToken);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

    }
}
