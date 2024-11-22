using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using RealEstateDapper8.Dtos.BottomGridDtos;

using RealEstateDapper8.Repositories.BottomRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomController : ControllerBase
    {
        private readonly IBottomRepository _bottomRepository;

        public BottomController(IBottomRepository bottomRepository)
        {
            _bottomRepository = bottomRepository;
        }
        [HttpGet]
        public async Task< IActionResult> BottomList()
        {
            var values = await _bottomRepository.GetAllBottomGrid();
            return Ok(values);  
        }
        [HttpPost]
        public async Task<IActionResult>CreateBottom(CreateBottomGridDto createBottomGridDto)
        {

         await  _bottomRepository.CreateBottom(createBottomGridDto);
            return Ok("Bottom eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletBottomgrid(int id)
        {

          await  _bottomRepository.DeletBottom(id);
            return Ok("Bottom silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBottomgrid(UpdateBottomGridDto updateBottomGridDto)
        {

         await   _bottomRepository.UpdateBottom(updateBottomGridDto);
            return Ok("Bottom güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottom(int id)
        {
            var value = await _bottomRepository.GetBottomGrid(id);
            return Ok(value);

        }

    }
}
