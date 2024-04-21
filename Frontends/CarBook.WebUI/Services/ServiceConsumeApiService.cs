using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class ServiceConsumeApiService : GenericConsumeApiService<ResultServiceDto, CreateServiceDto, UpdateServiceDto>, IServiceConsumeApiService
    {
        public ServiceConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client,shared)
        {
        }
    }
}
