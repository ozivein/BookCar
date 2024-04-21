using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persitence.Context;

namespace UdemyCarBook.Persitence.Repositories
{
    public class CarFeatureRepository : ICarFeatureRepository
    {
        private readonly CarBookContext _context;

        public CarFeatureRepository(CarBookContext context)
        {
            _context = context;
        }


        public async Task<List<CarFeature>> GetCarFeatureByCarId(int CarId)
        {
            return await _context.CarFeatures.Include(x => x.Card).Include(x => x.Feature).AsNoTracking().Where(x => x.CarId == CarId).ToListAsync();
        }

        public async Task UpdateCarFeatureAvailableChangeToFalse(int CarFeatureId)
        {
            await _context.CarFeatures.Where(x => x.CarFeatureId == CarFeatureId).ExecuteUpdateAsync(x => x.SetProperty(y => y.Available, false));
        }

        public async Task UpdateCarFeatureAvailableChangeToTrue(int CarFeatureId)
        {
            await _context.CarFeatures.Where(x => x.CarFeatureId == CarFeatureId).ExecuteUpdateAsync(x => x.SetProperty(y => y.Available, true));
        }
    }
}
