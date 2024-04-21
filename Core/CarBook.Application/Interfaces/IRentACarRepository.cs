using System.Linq.Expressions;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Interfaces
{
    public interface IRentACarRepository
    {
        Task<List<RentACar>> GetFilterRenACar(Expression<Func<RentACar, bool>> filter);
    }
}
