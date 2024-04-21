using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class TagCloudConsumeApiService : GenericConsumeApiService<ResultTagCloudDto, CreateTagCloudDto, UpdateTagCloudDto>, ITagCloudConsumeApiService
    {
        private readonly HttpClient _client;
        private readonly ISharedAuthorizationApiService _shared;
        public TagCloudConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
            _client = client;
            _shared = shared;
        }

        public async Task<List<GetTagCloudByBlogIdDto>> GetTagCloudByBlogIdListAsync(int id, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            return await _client.GetFromJsonAsync<List<GetTagCloudByBlogIdDto>>($"TagClouds/GetTagCloudByBlogIdList/{id}");
        }
    }
}
