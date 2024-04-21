using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class GenericConsumeApiService<resultDto, createDto, updateDto> : IGenericConsumeApiService<resultDto, createDto, updateDto>
        where resultDto : class
        where createDto : class
        where updateDto : class
    {
        private readonly HttpClient _client;
        private readonly ISharedAuthorizationApiService _shared;
        public GenericConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared)
        {
            _client = client;
            _shared = shared;
        }

        public async Task<HttpResponseMessage> CreateAsync(string controllerName, createDto entity, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            return await _client.PostAsJsonAsync<createDto>(controllerName, entity);

        }

        public async Task<HttpResponseMessage> RemoveAsync(string controllerName, int id, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            return await _client.DeleteAsync($"{controllerName}/{id}");
        }

        public async Task<HttpResponseMessage> UpdateAsync(string controllerName, updateDto entity, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            return await _client.PutAsJsonAsync<updateDto>(controllerName, entity);

        }

        public async Task<resultDto> GetByIdAsync(string controllerName, int id, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            return await _client.GetFromJsonAsync<resultDto>($"{controllerName}/{id}");


        }
        public async Task<updateDto> GetByIdUpdateAsync(string controllerName, int id, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            return await _client.GetFromJsonAsync<updateDto>($"{controllerName}/{id}");

        }
        public async Task<List<resultDto>> GetListAsync(string controllerName, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            return await _client.GetFromJsonAsync<List<resultDto>>(controllerName);
        }
        public async Task<List<resultDto>> GetListAsync(string controllerName, string actionName, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            return await _client.GetFromJsonAsync<List<resultDto>>($"{controllerName}/{actionName}");
        }

    }
}
