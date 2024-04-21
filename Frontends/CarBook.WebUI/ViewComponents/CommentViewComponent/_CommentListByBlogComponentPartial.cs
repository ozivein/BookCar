using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.CommentViewComponent
{
    public class _CommentListByBlogComponentPartial : ViewComponent
    {
        private readonly ICommentConsumeApiService _commentConsumeApiService;
        private readonly IDataProtector _dataProtector;
        private readonly ISharedAuthorizationApiService _shared;
        public _CommentListByBlogComponentPartial(ICommentConsumeApiService commentConsumeApiService, IDataProtectionProvider dataProtector, ISharedAuthorizationApiService shared)
        {
            _commentConsumeApiService = commentConsumeApiService;
            _dataProtector = dataProtector.CreateProtector("BlogController");
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync(string id)
        {
            var dataId = int.Parse(_dataProtector.Unprotect(id));
            
            return View(await _commentConsumeApiService.GetCommentByBlogIdListAsync(dataId, _shared.AccessToken));
        }
    }
}
