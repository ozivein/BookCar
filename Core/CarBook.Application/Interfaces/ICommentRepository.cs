using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetCommentByBlogIdListAsync(int blogId);
        Task<int> BlogCommentCountAsync(int blogId);

    }
}
