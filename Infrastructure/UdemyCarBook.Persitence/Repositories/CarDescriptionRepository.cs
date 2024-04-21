using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persitence.Context;

namespace UdemyCarBook.Persitence.Repositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookContext _context;

        public CarDescriptionRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<CarDescription> GetCarDescrpitonByCarIdAsync(int carId)
        {
            var values = await _context.CarDescriptions.Where(x => x.CarId == carId).FirstOrDefaultAsync();
            if (values is not null)
            {
                return values;
            }
            return new CarDescription { CarId = carId };

        }
    }
}
