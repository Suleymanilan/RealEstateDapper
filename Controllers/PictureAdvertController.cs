using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.CategoryDtos;
using RealEstateDapper8.Dtos.PictureAdvertDto;
using RealEstateDapper8.Repositories.PictureAdvertRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PictureAdvertController : ControllerBase
    {
        private readonly IPictureAdvertRepository _pictureAdvertRepository;

        public PictureAdvertController(IPictureAdvertRepository pictureAdvertRepository)
        {
            _pictureAdvertRepository = pictureAdvertRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PictureAdvertList()
        {

            var values = await _pictureAdvertRepository.GetAllPictureAdvert();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePictureAdvert(CreatePictureAdvertDto createPictureAdvertDto)
        {

            await _pictureAdvertRepository.CreatePictureAdvertİmage(createPictureAdvertDto);
            return Ok("Resim eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletPictureAdvert(int id)
        {

            await _pictureAdvertRepository.DeletPictureAdvert(id);
            return Ok("Resim silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePictureAdvert(UpdatePictureAdvertDto updatePictureAdvertDto)
        {

            await _pictureAdvertRepository.UpdatePictureAdvert(updatePictureAdvertDto);
            return Ok("Resim güncellendi");
        }


        [HttpGet("GetByPictureAdvert")]
        public async Task<IActionResult> GetByPictureAdvert(int id)
        {

            var value = await  _pictureAdvertRepository.GetByPictureAdvert(id);
            return Ok(value);
        }
    }
}
