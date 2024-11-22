using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.ServiceDtos;
using RealEstateDapper8.Dtos.TestimonialDtos;
using RealEstateDapper8.Repositories.ServiceRepository;
using RealEstateDapper8.Repositories.TestimonialRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialRepository _testimonialRepository;

        public TestimonialController(ITestimonialRepository testimonialRepository)
        {
            _testimonialRepository = testimonialRepository;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialList()
        {

            var values = await _testimonialRepository.GetAllTestimonial();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult>CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
         await   _testimonialRepository.CrerateTestimonial(createTestimonialDto);
            return Ok();

        }
        [HttpDelete]
        public async Task<IActionResult> DeletTestimonial(int id)
        {

          await _testimonialRepository.DeleteTestimonial(id);
            return Ok("testimonial silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {

        await  _testimonialRepository.UpdateTestimonial(updateTestimonialDto);
            return Ok("testimonial güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await _testimonialRepository.GetTestimonial(id);
            return Ok(value);

        }

    }
}
