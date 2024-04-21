using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsRecentBlogsComponenetPartial : ViewComponent
    {
        private readonly IBlogConsumeApiService _blogConsumeApiService;
        private readonly ISharedAuthorizationApiService _shared;
        public _BlogDetailsRecentBlogsComponenetPartial(IBlogConsumeApiService blogConsumeApiService, ISharedAuthorizationApiService shared)
        {
            _blogConsumeApiService = blogConsumeApiService;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _blogConsumeApiService.GetLastThreeBlogWithAuthorList(_shared.AccessToken));
        }
    }
}
