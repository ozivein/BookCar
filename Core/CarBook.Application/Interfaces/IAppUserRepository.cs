using System.Linq.Expressions;
using UdemyCarBook.Domain;

namespace UdemyCarBook.Application.Interfaces
{
    public interface IAppUserRepository
    {
        Task<AppUser> GetCheckAppUserAndRoleAsync(Expression<Func<AppUser, bool>> filter);
    }
}
