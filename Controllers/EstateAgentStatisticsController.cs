using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Repositories.EstateAgentRepository.DashboardRepository.StatisticesRepository;


namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentStatisticsController : ControllerBase
    {
        private readonly IStatisticesRepository _statisticesRepository;

        public EstateAgentStatisticsController(IStatisticesRepository statisticesRepository)
        {
            _statisticesRepository = statisticesRepository;
        }
        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_statisticesRepository.AllProductCount());
        }
        [HttpGet("ProductCountByAgentId")]
        public IActionResult ProductCountByAgentId(int id)
        {
            return Ok(_statisticesRepository.ProductCountByAgentId(id));
        }
        [HttpGet("ProductCountByStatusTrue")]
        public IActionResult ProductCountByStatusTrue(int id)
        {
            return Ok(_statisticesRepository.ProductCountByStatusTrue(id));
        }
        [HttpGet("ProductCountByStatusFalse")]
        public IActionResult ProductCountByStatusFalse(int id)
        {
            return Ok(_statisticesRepository.ProductCountByStatusFalse(id));
        }
    }
}
