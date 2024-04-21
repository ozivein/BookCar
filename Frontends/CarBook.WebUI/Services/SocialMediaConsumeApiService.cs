using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class SocialMediaConsumeApiService : GenericConsumeApiService<ResultSocialMediaDto, CreateSocialMediaDto, UpdateSocialMediaDto>, ISocialMediaConsumeApiService
    {
        public SocialMediaConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
