using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogViewComponentPartial : ViewComponent
    {
        private readonly IBlogConsumeApiService _blogConsumeApiService;
        private readonly IDataProtector _dataProtector;
        private readonly ISharedAuthorizationApiService _shared;
        public _BlogViewComponentPartial(IBlogConsumeApiService blogConsumeApiService, IDataProtectionProvider dataProvider, ISharedAuthorizationApiService shared)
        {
            _blogConsumeApiService = blogConsumeApiService;
            _dataProtector = dataProvider.CreateProtector("BlogController");
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _blogConsumeApiService.GetLastThreeBlogWithAuthorList(_shared.AccessToken);
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.BlogId.ToString()));
            return View(values);
        }
    }
}
