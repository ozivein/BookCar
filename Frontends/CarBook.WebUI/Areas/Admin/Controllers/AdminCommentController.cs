using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class AdminCommentController : Controller
    {
        private readonly ICommentConsumeApiService _commentConsumeApiService;
        private readonly IDataProtector _dataProtector;
        private readonly ISharedAuthorizationApiService _shared;
        public AdminCommentController(ICommentConsumeApiService commentConsumeApiService, IDataProtectionProvider dataProtector, ISharedAuthorizationApiService shared)
        {
            _commentConsumeApiService = commentConsumeApiService;
            _dataProtector = dataProtector.CreateProtector("AdminBlogController");
            _shared = shared;
        }

        public async Task<IActionResult> Index(string id)
        {
            var dataId = int.Parse(_dataProtector.Unprotect(id));
            ViewBag.BlogId = dataId;
            return View(await _commentConsumeApiService.GetCommentByBlogIdListAsync(dataId,_shared.AccessToken));
        }
    }
}
