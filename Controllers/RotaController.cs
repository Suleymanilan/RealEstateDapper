using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.RotaDtos;
using RealEstateDapper8.Repositories.CategoryRepository;
using RealEstateDapper8.Repositories.RotaRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RotaController : ControllerBase
    {
        private readonly IRotaRepository _rotaRepository;

        public RotaController(IRotaRepository rotaRepository)
        {
            _rotaRepository = rotaRepository;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> OneRotalar(int id)
        {
            var value = await _rotaRepository.OneRota(id);
            return Ok(value);

        }
        [HttpGet]
        public async Task<IActionResult> RotaList()
        {

            var values = await _rotaRepository.GetAllRota();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRota(CreateRotaDto createRotaDto)
        {

          await  _rotaRepository.CreateRota(createRotaDto);
            return Ok("Lokasyon eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletRota(int id)
        {

          await _rotaRepository.DeletRota(id);
            return Ok("Lokasyon silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRota(UpdateRotaDto updateRotaDto)
        {

          await  _rotaRepository.UpdateRota(updateRotaDto);
            return Ok("Lokasyon güncellendi");
        }
    }
}
