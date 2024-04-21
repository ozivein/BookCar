using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Persitence.Context;

namespace UdemyCarBook.Persitence.Repositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly CarBookContext _context;

        public StatisticRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<int> GetLocationCount()
        {
            return await _context.Locations.CountAsync();
        }
        public async Task<int> GetCarCount()
        {

            return await _context.Cars.CountAsync();

        }

        public async Task<int> GetAuthorCount()
        {
            return await _context.Authors.CountAsync();
        }

        public async Task<int> GetBlogCount()
        {
            return await _context.Blogs.CountAsync();
        }

        public async Task<int> GetBrandCount()
        {
            return await _context.Brands.CountAsync();
        }

        public async Task<decimal> GetDailiyCarPricingAvgPrice()
        {
            return await _context.CarPricings.Include(x => x.Pricing).Include(x => x.Car).Where(x => x.Pricing.Name == "Günlük").AverageAsync(x => x.Amaount);
        }

        public async Task<decimal> GetWeeklyCarPricingAvgPrice()
        {
            return await _context.CarPricings.Include(x => x.Pricing).Include(x => x.Car).Where(x => x.Pricing.Name == "Haftalık").AverageAsync(x => x.Amaount);
        }

        public async Task<decimal> GetMountlyCarPricingAvgPrice()
        {
            return await _context.CarPricings.Include(x => x.Pricing).Include(x => x.Car).Where(x => x.Pricing.Name == "Aylık").AverageAsync(x => x.Amaount);
        }

        public async Task<int> GetCarCountByTransmissonAuto()
        {
            return await _context.Cars.Where(x => x.Transmission == "Otomatik").CountAsync();
        }

        public async Task<string> GetBrandNameByMaxCar()
        {
            return await _context.Cars.Include(x => x.Brand).GroupBy(x => x.Brand.Name).Select(x =>
            new
            {
                BrandName = x.Key,
                Count = x.Count()
            }).OrderByDescending(x => x.Count).Take(1).Select(x => x.BrandName).FirstOrDefaultAsync();
        }

        public async Task<string> GetTitleByMaxBlogComment()
        {
            return await _context.Comments.Include(x => x.Blog).GroupBy(x => x.Blog.Title).Select(x => new
            {
                BlogTitle = x.Key,
                Count = x.Count()
            }).OrderByDescending(x => x.Count).Take(1).Select(x => x.BlogTitle).FirstOrDefaultAsync();
        }

        public async Task<int> GetCarCountByKmSmallerThen1000()
        {
            return await _context.Cars.Where(x => x.Km < 1000).CountAsync();
        }

        public async Task<int> GetCarCountByFuelGassolineOrDiesel()
        {
            return await _context.Cars.Where(x => x.Fuel == "Dizel" || x.Fuel == "Benzin").CountAsync();
        }

        public async Task<int> GetCarCountByFuelElectic()
        {
            return await _context.Cars.Where(x => x.Fuel == "Elektrik").CountAsync();
        }

        public async Task<string> GetCarBrandAndModelByRentPriceDailyMin()
        {
            return await _context.CarPricings.Include(x => x.Car).Include(x => x.Pricing).Where(x => x.Pricing.Name == "Günlük").OrderBy(x => x.Amaount).Select(x => x.Car.Model).FirstOrDefaultAsync();
        }

        public async Task<string> GetCarBrandAndModelByRentPriceDailyMax()
        {
            return await _context.CarPricings.Include(x => x.Car).Include(x => x.Pricing).Where(x => x.Pricing.Name == "Günlük").OrderByDescending(x => x.Amaount).Select(x => x.Car.Model).FirstOrDefaultAsync();
        }
    }
}
