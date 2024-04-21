using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain;
using UdemyCarBook.Persitence.Context;

namespace UdemyCarBook.Persitence.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly CarBookContext _context;

        public AppUserRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<AppUser> GetCheckAppUserAndRoleAsync(Expression<Func<AppUser, bool>> filter)
        {
            var values = await _context.AppUsers.Include(x => x.AppRole).Where(filter).FirstOrDefaultAsync();
            if (values is not null)
            {
                return values;
            }
            return new AppUser();
        }
    }
}
