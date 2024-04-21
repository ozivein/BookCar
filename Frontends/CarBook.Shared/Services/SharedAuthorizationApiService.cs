using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

namespace UdemyCarBook.Shared.Services
{
    public class SharedAuthorizationApiService : ISharedAuthorizationApiService
    {
        private readonly IHttpContextAccessor _context;

        public SharedAuthorizationApiService(IHttpContextAccessor context)
        {

            _context = context;
        }


        public string AccessToken => _context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == "accessToken")?.Value;

        public void TokenHeaderAuthorization(HttpClient client, string token)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);

        }
    }
}
