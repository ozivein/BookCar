using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class CategoryConsumeApiService : GenericConsumeApiService<ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>, ICategoryConsumeApiService
    {
        public CategoryConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
