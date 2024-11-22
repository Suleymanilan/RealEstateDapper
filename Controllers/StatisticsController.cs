using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Repositories.StatisticsRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {

        private readonly IStatisticsRepository _statisticsRepository;

        public StatisticsController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {

            return Ok(_statisticsRepository.CategoryCount());
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {

            return Ok(_statisticsRepository.ActiveCategoryCount());
        }
        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_statisticsRepository.PassiveCategoryCount());


        }
        [HttpGet("ActiveAgentCount")]
        public IActionResult ActiveAgentCount()
        {

            return Ok(_statisticsRepository.ActiveAgentCount());
        }
     
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_statisticsRepository.ProductCount());
        }
        [HttpGet("ApartmentCount")]
        public IActionResult ApartmentCount()
        {
            return Ok(_statisticsRepository.ApartmentCount());
        }
        [HttpGet("AgentNameByMaxProductCount")]
        public IActionResult AgentNameByMaxProductCount()
        {
            return Ok(_statisticsRepository.AgentNameByMaxProductCount());
        }
        [HttpGet("CategoryNameByMaxProductCount")]
        public IActionResult CategoryNameByMaxProductCount()
        {
            return Ok(_statisticsRepository.CategoryNameByMaxProductCount());
        }
        [HttpGet("AverageProductPriceByRent")]
        public IActionResult AverageProductPriceByRent()
        {
            return Ok(_statisticsRepository.AverageProductPriceByRent());
        }
        [HttpGet("AverageProductPriceBySeal")]
        public IActionResult AverageProductPriceBySeal()
        {
            return Ok(_statisticsRepository.AverageProductPriceBySeal());
        }

        [HttpGet("AverageRoomCount")]
        public IActionResult AverageRoomCount()
        {
            return Ok(_statisticsRepository.AverageRoomCount());
        }
        [HttpGet("CityNameByMaxProductCount")]
        public IActionResult CityNameByMaxProductCount()
        {
            return Ok(_statisticsRepository.CityNameByMaxProductCount());
        }
        [HttpGet("DifferentCityCount")]
        public IActionResult DifferentCityCount()
        {
            return Ok(_statisticsRepository.DifferentCityCount());
        }
        [HttpGet("LastProductPrice")]
        public IActionResult LastProductPrice()
        {
            return Ok(_statisticsRepository.LastProductPrice());
        }
        [HttpGet("NewestBuildingYear")]
        public IActionResult NewestBuildingYear()
        {
            return Ok(_statisticsRepository.NewestBuildingYear());
        }
        [HttpGet("OldestBuildingYear")]
        public IActionResult OldestBuildingYear()
        {
            return Ok(_statisticsRepository.OldestBuildingYear());
        }
    }
}