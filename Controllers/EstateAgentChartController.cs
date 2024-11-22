using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Repositories.EstateAgentRepository.DashboardRepository.ChartRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentChartController : ControllerBase
    {
        private readonly IChartRepository _chartRepository;

        public EstateAgentChartController(IChartRepository chartRepository)
        {
            _chartRepository = chartRepository;
        }
        [HttpGet]
        public async Task<IActionResult> AgentDasboardChart()
        {

            //var values = await _chartRepository.Get5CityChart();
            return Ok(await _chartRepository.Get5CityChart());
        }
    }
}
