using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface ITagCloudRepository
    {
        Task<List<TagCloud>> GetTagCloudByBlogIdListAsync(int id); 
    }
}
