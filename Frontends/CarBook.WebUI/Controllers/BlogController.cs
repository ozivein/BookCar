using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogConsumeApiService _blogConsumeApiService;
        private readonly IDataProtector _dataProtector;

        public BlogController(IBlogConsumeApiService blogConsumeApiService, IDataProtectionProvider dataProvider)
        {
            _blogConsumeApiService = blogConsumeApiService;
            _dataProtector = dataProvider.CreateProtector("BlogController");
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Blog";
            ViewBag.v2 = "Yazarlarımızın Blogları";
            var values = await _blogConsumeApiService.GetListAsync("Blogs", "GetBlogWithAuthorAndCategoryList");
            values.ForEach(x => x.DataProtect = _dataProtector.Protect(x.BlogId.ToString()).ToString());
            return View(values);
        }

        public IActionResult BlogDetail(string id)
        {
            ViewBag.dataProtectBlogId = id;
            ViewBag.v1 = "Blog";
            ViewBag.v2 = "Blog Detayı ve Yorumlar";
            return View();
        }
    }
}
