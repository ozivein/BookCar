using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persitence.Context;

namespace UdemyCarBook.Persitence.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly CarBookContext _context;

        public BlogRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<Blog>> GetBlogWithAuthorAndCategoryListAsync()
        {
            return await _context.Blogs.Include(b => b.Author).Include(c => c.Category).ToListAsync();
        }

        public async Task<Blog> GetBlogWithAuthorListAsync()
        {
            return await _context.Blogs.AsNoTracking().Include(x => x.Author).FirstOrDefaultAsync();
        }

        public async Task<List<Blog>> GetLastThreeBlogsWithAuthorsAndCategoryAsync()
        {
            return await _context.Blogs.Include(b => b.Author).Include(c => c.Category).Take(3).OrderByDescending(x => x.BlogId).ToListAsync();
        }
    }
}
