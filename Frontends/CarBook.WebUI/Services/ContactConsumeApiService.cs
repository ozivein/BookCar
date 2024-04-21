using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class ContactConsumeApiService : GenericConsumeApiService<ResultContactDto, CreateContactDto, UpdateContactDto>, IContactConsumeApiService
    {
        public ContactConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
