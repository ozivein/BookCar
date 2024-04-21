using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailCloudTagByBlogComponentPartial : ViewComponent
    {
        private readonly ITagCloudConsumeApiService _tagCloudConsumeApiService;
        private readonly IDataProtector _dataProtector;
        private readonly ISharedAuthorizationApiService _shared;
        public _BlogDetailCloudTagByBlogComponentPartial(ITagCloudConsumeApiService tagCloudConsumeApiService, IDataProtectionProvider dataProtector, ISharedAuthorizationApiService shared)
        {
            _tagCloudConsumeApiService = tagCloudConsumeApiService;
            _dataProtector = dataProtector.CreateProtector("BlogController");
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var dataId = int.Parse(_dataProtector.Unprotect(id));

            return View(await _tagCloudConsumeApiService.GetTagCloudByBlogIdListAsync(dataId,_shared.AccessToken));
        }
    }
}
