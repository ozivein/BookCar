using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persitence.Context;

namespace UdemyCarBook.Persitence.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly CarBookContext _context;

        public CommentRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<int> BlogCommentCountAsync(int blogId)
        {
            return await _context.Comments.Where(x => x.BlogId == blogId).CountAsync();
        }

        public async Task<List<Comment>> GetCommentByBlogIdListAsync(int blogId)
        {
            return await _context.Comments.AsNoTracking().Where(x => x.BlogId == blogId).ToListAsync();
        }
    }
}
