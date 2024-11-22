using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.TuDoListDtos;
using RealEstateDapper8.Repositories.TuDoListRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuDoListController : ControllerBase
    {
        private readonly ITuDoListRepository _tuDoListRepository;

        public TuDoListController(ITuDoListRepository tuDoListRepository)
        {
            _tuDoListRepository = tuDoListRepository;
        }
        [HttpGet]
        public async Task<IActionResult> TuDoList()
        {

            var values = await _tuDoListRepository.GetAllTuDoListAsync();
            return Ok(values);
        }

        [HttpGet("Last5TuDoListAsync")]
        public async Task<IActionResult> Last5TuDoListAsync()
        {

            var values = await _tuDoListRepository.Last5TuDoListAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTuDoList(CreateTuDoListDto createTuDoListDto)
        {

          await  _tuDoListRepository.CreateTuDoList(createTuDoListDto);
            return Ok("TuDo eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletTuDoList(int id)
        {

           await _tuDoListRepository.DeletTuDoList(id);
            return Ok("TuDo silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateTuDoLsitDto updateTuDoLsitDto)
        {

       await   _tuDoListRepository.UpdateTuDoList(updateTuDoLsitDto);
            return Ok("TuDo güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTuDo(int id)
        {
            var value = await _tuDoListRepository.GetTuDoList(id);
            return Ok(value);

        }
    }
}
