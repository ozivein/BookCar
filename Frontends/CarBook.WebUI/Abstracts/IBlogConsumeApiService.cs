using UdemyCarBook.Dto.Dtos;

namespace UdemyCarBook.WebUI.Abstracts
{
    public interface IBlogConsumeApiService:IGenericConsumeApiService<ResultBlogDto,CreateBlogDto,UpdateBlogDto>
    {
        Task<List<ResultLastThreeBlogWithAuthorDto>> GetLastThreeBlogWithAuthorList(string token);
        Task<GetBlogWithAuthorDto> GetBlogWithAuthorListAsync(int id,string token);
        Task<List<GetBlogWithAuthorAndCategoryDto>> GetBlogWithAuthorAndCategoryListAsync(string token);
    }
}
