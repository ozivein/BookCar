using MediatR;
using Microsoft.AspNetCore.Mvc;
using UdemyCarBook.Application.Features.Mediator.Queries;

namespace UdemyCarBook.WebApi.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediatR;

        public StatisticsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetCountCar()
        {
            return Ok(await _mediatR.Send(new GetCarCountQuery()));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetBrandCar()
        {
            return Ok(await _mediatR.Send(new GetBrandCountQuery()));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCountLocation()
        {
            return Ok(await _mediatR.Send(new GetLocationCountQuery()));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCountAuthor()
        {
            return Ok(await _mediatR.Send(new GetAuthorCountQuery()));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCountBlog()
        {
            return Ok(await _mediatR.Send(new GetBlogCountQuery()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetDailiyCarPricingAvgPrice()
        {
            return Ok(await _mediatR.Send(new GetDailiyCarPricingAvgPriceQuery()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetWeeklyCarPricingAvgPrice()
        {
            return Ok(await _mediatR.Send(new GetWeeklyCarPricingAvgPriceQuery()));
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetHourslyCarPricingAvgPrice()
        {
            return Ok(await _mediatR.Send(new GetMountlyCarPricingAvgPriceQuery()));
        }
        
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCarCountByTransmissonAuto()
        {
            return Ok(await _mediatR.Send(new GetCarCountByTransmissonAutoQuery()));
        }
        
        [HttpGet("[action]")]
        public async Task<IActionResult> GetBrandNameByMaxCar()
        {
            return Ok(await _mediatR.Send(new GetBrandNameByMaxCarQuery()));
        }
        
        [HttpGet("[action]")]
        public async Task<IActionResult> GetTitleByMaxBlogComment()
        {
            return Ok(await _mediatR.Send(new GetTitleByMaxBlogCommentQuery()));
        }
        
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCarCountByKmSmallerThen1000()
        {
            return Ok(await _mediatR.Send(new GetCarCountByKmSmallerThen1000Query()));
        }
        
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCarCountByFuelGassolineOrDiesel()
        {
            return Ok(await _mediatR.Send(new GetCarCountByFuelGassolineOrDieselQuery()));
        }
        
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCarCountByFuelElectic()
        {
            return Ok(await _mediatR.Send(new GetCarCountByFuelElecticQuery()));
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMin()
        {
            return Ok(await _mediatR.Send(new GetCarBrandAndModelByRentPriceDailyMinQuery()));
        }
        
        [HttpGet("[action]")]
        public async Task<IActionResult> GetCarBrandAndModelByRentPriceDailyMax()
        {
            return Ok(await _mediatR.Send(new GetCarBrandAndModelByRentPriceDailyMaxQuery()));
        }
    }
}
