using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsAuthorAboutComponentPartial : ViewComponent
    {
        private readonly IBlogConsumeApiService _blogConsumeApiService;
        private readonly IDataProtector _dataProtector;
        private readonly ISharedAuthorizationApiService _shared;
        public _BlogDetailsAuthorAboutComponentPartial(IBlogConsumeApiService blogConsumeApiService, IDataProtectionProvider dataProtector, ISharedAuthorizationApiService shared)
        {
            _blogConsumeApiService = blogConsumeApiService;
            _dataProtector = dataProtector.CreateProtector("BlogController");
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var dataId = int.Parse(_dataProtector.Unprotect(id));
            return View(await _blogConsumeApiService.GetBlogWithAuthorListAsync(dataId, _shared.AccessToken));
        }
    }
}
