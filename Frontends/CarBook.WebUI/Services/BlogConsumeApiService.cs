using UdemyCarBook.Dto.Dtos;
using UdemyCarBook.Shared.Services;
using UdemyCarBook.WebUI.Abstracts;

namespace UdemyCarBook.WebUI.Services
{
    public class BlogConsumeApiService : GenericConsumeApiService<ResultBlogDto, CreateBlogDto, UpdateBlogDto>, IBlogConsumeApiService
    {
        private readonly HttpClient _httpClient;
        private readonly ISharedAuthorizationApiService _shared;
        public BlogConsumeApiService(HttpClient client,ISharedAuthorizationApiService shared) : base(client , shared)
        {
            _httpClient = client;
            _shared= shared;
        }

        public async Task<List<GetBlogWithAuthorAndCategoryDto>> GetBlogWithAuthorAndCategoryListAsync(string token)
        {
            _shared.TokenHeaderAuthorization(_httpClient,token);
            return await _httpClient.GetFromJsonAsync<List<GetBlogWithAuthorAndCategoryDto>>($"Blogs/GetBlogWithAuthorAndCategoryList");
        }

        public async Task<GetBlogWithAuthorDto> GetBlogWithAuthorListAsync(int id,string token)
        {
            _shared.TokenHeaderAuthorization(_httpClient, token);

            return await _httpClient.GetFromJsonAsync<GetBlogWithAuthorDto>($"Blogs/GetBlogWithAuthorList/{id}");
        }

        public async Task<List<ResultLastThreeBlogWithAuthorDto>> GetLastThreeBlogWithAuthorList(string token)
        {
            _shared.TokenHeaderAuthorization(_httpClient, token);

            return await _httpClient.GetFromJsonAsync<List<ResultLastThreeBlogWithAuthorDto>>("Blogs/GetLastThreeBlogsWithAuthorsAndCategory");
        }
    }
}
