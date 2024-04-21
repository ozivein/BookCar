using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsCategoryComponentPartial : ViewComponent
    {
        private readonly ICategoryConsumeApiService _categoryConsumeApiService;
        private readonly ISharedAuthorizationApiService _shared;
        public _BlogDetailsCategoryComponentPartial(ICategoryConsumeApiService categoryConsumeApiService, ISharedAuthorizationApiService shared)
        {
            _categoryConsumeApiService = categoryConsumeApiService;
            _shared = shared;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _categoryConsumeApiService.GetListAsync("Categories", _shared.AccessToken));
        }
    }
}
