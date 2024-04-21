using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class ReservationConsumeApiService : GenericConsumeApiService<ResultReservationDto, CreateReservationDto, UpdateReservationDto>, IReservationConsumeApiService
    {
        public ReservationConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
