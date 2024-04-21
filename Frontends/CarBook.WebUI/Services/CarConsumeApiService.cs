using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class CarConsumeApiService : GenericConsumeApiService<ResultCarDto, CreateCarDto, UpdateCarDto>, ICarConsumeApiService
    {
        public CarConsumeApiService(HttpClient client,ISharedAuthorizationApiService shared) : base(client,shared)
        {
        }
    }
}
