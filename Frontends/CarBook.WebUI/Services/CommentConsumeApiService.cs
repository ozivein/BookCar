using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class CommentConsumeApiService : GenericConsumeApiService<ResultCommentDto, CreateCommentDto, UpdateCommentDto>, ICommentConsumeApiService
    {
        private readonly HttpClient _client;
        private readonly ISharedAuthorizationApiService _shared;
        public CommentConsumeApiService(HttpClient client, ISharedAuthorizationApiService shared) : base(client, shared)
        {
            _client = client;
            _shared = shared;
        }

        public async Task<ResultCommentBlogCountDto> GetBlogCommentCountAsync(int id, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);
            return await _client.GetFromJsonAsync<ResultCommentBlogCountDto>($"Comments/GetBlogCommentCount/{id}");
        }

        public async Task<List<GetCommentByBlogIdDto>> GetCommentByBlogIdListAsync(int id, string token)
        {
            _shared.TokenHeaderAuthorization(_client, token);

            return await _client.GetFromJsonAsync<List<GetCommentByBlogIdDto>>($"Comments/GetCommentByBlogId/{id}");
        }
    }
}
