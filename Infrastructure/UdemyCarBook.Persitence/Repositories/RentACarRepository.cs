using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persitence.Context;

namespace UdemyCarBook.Persitence.Repositories
{
    public class RentACarRepository : IRentACarRepository
    {
        private readonly CarBookContext _context;

        public RentACarRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<RentACar>> GetFilterRenACar(Expression<Func<RentACar, bool>> filter)
        {
            return await _context.RentACars.Include(x => x.Car).ThenInclude(x => x.Brand).Where(filter).ToListAsync();
        }
    }
}
