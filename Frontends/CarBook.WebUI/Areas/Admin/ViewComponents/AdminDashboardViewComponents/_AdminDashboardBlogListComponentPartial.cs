using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Areas.Admin.ViewComponents.AdminDashboardViewComponents
{
    public class _AdminDashboardBlogListComponentPartial : ViewComponent
    {
        private readonly IBlogConsumeApiService _blogConsumeApiService;
        private readonly ISharedAuthorizationApiService _shared;
        public _AdminDashboardBlogListComponentPartial(IBlogConsumeApiService blogConsumeApiService, ISharedAuthorizationApiService shared)
        {
            _blogConsumeApiService = blogConsumeApiService;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _blogConsumeApiService.GetBlogWithAuthorAndCategoryListAsync(_shared.AccessToken));
        }
    }
}
