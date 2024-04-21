using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class AboutConsumeApiService : GenericConsumeApiService<ResultAboutDto, CreateAboutDto, UpdateAboutDto>, IAboutConsumeApiService
    {
        public AboutConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client,shared)
        {
        }
    }
}
