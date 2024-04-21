using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class AuthorConsumeApiService : GenericConsumeApiService<ResultAuthorDto, CreateAuthorDto, UpdateAuthorDto>, IAuthorConsumeApiService
    {
        public AuthorConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
        }
    }
}
