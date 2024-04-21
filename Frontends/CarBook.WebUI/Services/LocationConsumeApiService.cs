using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class LocationConsumeApiService : GenericConsumeApiService<ResultLocationDto, CreateLocationDto, UpdateLocationDto>, ILocationConsumeApiService
    {
        public LocationConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
