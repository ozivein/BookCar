using Microsoft.EntityFrameworkCore;
using System.Data;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.ViewModels;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persitence.Context;

namespace UdemyCarBook.Persitence.Repositories
{
    public class CarPricingRepository : ICarPricingRepository
    {
        private readonly CarBookContext _context;

        public CarPricingRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<List<CarPricingViewModel>> GetCarPricingWithTimePeriod()
        {
            List<CarPricingViewModel> carPricingViewModels = new List<CarPricingViewModel>();

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {

                command.CommandText = "Select * from(Select Brands.Name+' '+Model as CarBrandModel,PricingId,Amaount,  Cars.CoverImageUrl from CarPricings inner join Cars on Cars.CarId=CarPricings.CarId inner join Brands on Brands.BrandId=Cars.BrandId) as SourceTable Pivot(Sum(Amaount) For PricingId in([2],[3],[4])) as PivotTable";
                command.CommandType = CommandType.Text;

                await _context.Database.OpenConnectionAsync();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarPricingViewModel value = new CarPricingViewModel();
                        value.ModelBrand = reader[0].ToString();
                        value.CoverImageUrl = reader[1].ToString();
                        Enumerable.Range(1, 3).ToList().ForEach(x =>
                        {

                            if (DBNull.Value.Equals(reader[x]))
                                value.Amounts.Add(0);
                            else
                                value.Amounts.Add(reader.GetDecimal(x + 1));



                        });
                        carPricingViewModels.Add(value);
                    }
                }
                await _context.Database.CloseConnectionAsync();
                return carPricingViewModels;

            }



        }

        public async Task<List<CarPricing>> GetCarWithPricingAndBrandDayList()
        {
            return await _context.CarPricings.Include(x => x.Pricing).Include(x => x.Car).ThenInclude(x => x.Brand).Where(x => x.PricingId == 3).ToListAsync();
        }

        public async Task<List<CarPricing>> GetCarWithPricingAndBrandList()
        {

            return await _context.CarPricings.Include(x => x.Pricing).Include(x => x.Car).ThenInclude(x => x.Brand).ToListAsync();
        }
    }
}


//var values = from x in _context.CarPricings
//             group x by x.PricingId into g
//             select new
//             {

//             }

//var values = await _context.CarPricings.GroupBy(x => x.PricingId).Select(x => new {

//    CarId = x.Key,
//    DailiyPrice = x.Where(x => x.PricingId == 2).Sum(x => x.Amaount),
//    WeeklyPrice = x.Where(x => x.PricingId == 3).Sum(x => x.Amaount),
//    MountlyPrice = x.Where(x => x.PricingId == 4).Sum(x => x.Amaount)
//}


//    ).ToListAsync();
//return values;

//List<CarPricingViewModel> carPricings = new List<CarPricingViewModel>();
//using (var command = _context.Database.GetDbConnection().CreateCommand())
//{

//    command.CommandText = "Select * from(Select Brands.Name+' '+Model as CarBrandModel, Cars.CoverImageUrl, PricingId, Amaount from CarPricings inner join Cars on Cars.CarId=CarPricings.CarId inner join Brands on Brands.BrandId=Cars.BrandId) as SourceTable Pivot(Sum(Amaount) For PricingId in([2],[3],[4])) as PivotTable";
//    command.CommandType = CommandType.Text;
//    await _context.Database.OpenConnectionAsync();
//    using (var reader = command.ExecuteReader())
//    {
//        while (reader.Read())
//        {
//            CarPricingViewModel carPricing = new CarPricingViewModel();

//            carPricing.ModelBrand = reader[0].ToString();
//            carPricing.CoverImageUrl = reader[1].ToString();
//            Enumerable.Range(1, 3).ToList().ForEach(x =>
//            {
//                if (DBNull.Value.Equals(reader[x]))
//                {
//                    carPricing.Amounts.Add(0);
//                }
//                else
//                {
//                    carPricing.Amounts.Add(reader.GetDecimal(x + 1));
//                }
//            });

//            carPricings.Add(carPricing);

//        }
//    }
//    await _context.Database.CloseConnectionAsync();
//    return carPricings;
//}