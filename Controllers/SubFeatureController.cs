using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.CategoryDtos;
using RealEstateDapper8.Dtos.SubFeatureDto;
using RealEstateDapper8.Repositories.SubFeatureRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubFeatureController : ControllerBase
    {
        private readonly ISubFeatureRepository _subFeatureRepository;

        public SubFeatureController(ISubFeatureRepository subFeatureRepository)
        {
            _subFeatureRepository = subFeatureRepository;
        }
        [HttpGet]
        public async Task<IActionResult> SubFeatureList()
        {

            var values = await _subFeatureRepository.GetAllSubFeatureAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSubFeature(CreateSubFeatureDto createSubFeatureDto)
        {

          await  _subFeatureRepository.CreateSubFeature(createSubFeatureDto);
            return Ok("Sub Feature eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletSubFeature(int id)
        {

         await  _subFeatureRepository.DeletSubFeature(id);
            return Ok("Sub Feature silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSubFeature(UpdateSubFeatureDto updateSubFeatureDto)
        {

        await  _subFeatureRepository.UpdateSubFeature(updateSubFeatureDto);
            return Ok("SubFeature güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubFeature(int id)
        {
            var value = await _subFeatureRepository.GetSubFeature(id);
            return Ok(value);

        }
    }
}
