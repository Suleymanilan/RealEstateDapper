using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Repositories.EstateAgentRepository.DashboardRepository.LastProductRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductController : ControllerBase
    {
        private readonly ILast5ProductRepository _last5ProductRepository;

        public EstateAgentLastProductController(ILast5ProductRepository last5ProductRepository)
        {
            _last5ProductRepository = last5ProductRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductAdvert5ByAgent(int id)
        {

            var values = await _last5ProductRepository.ProductAdvert5ByAgent(id);
            return Ok(values);
        }
    }
}
