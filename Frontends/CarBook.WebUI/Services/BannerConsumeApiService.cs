using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class BannerConsumeApiService : GenericConsumeApiService<ResultBannerDto, CreateBannerDto, UpdateBannerDto>, IBannerConsumeApiService
    {
        public BannerConsumeApiService(HttpClient client,ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
