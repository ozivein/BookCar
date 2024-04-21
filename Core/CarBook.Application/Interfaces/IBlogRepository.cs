using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface IBlogRepository
    {
        Task<List<Blog>> GetBlogWithAuthorAndCategoryListAsync();
        Task<Blog> GetBlogWithAuthorListAsync();
        Task<List<Blog>> GetLastThreeBlogsWithAuthorsAndCategoryAsync();
    }
}
