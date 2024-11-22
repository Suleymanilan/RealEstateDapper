using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.ProductAmenitiesDto;
using RealEstateDapper8.Repositories.ProductAmenitiesRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAmeniteisController : ControllerBase
    {
        private readonly IProductAmenitiesRepository _productAmenitiesRepository;

        public ProductAmeniteisController(IProductAmenitiesRepository productAmenitiesRepository)
        {
            _productAmenitiesRepository = productAmenitiesRepository;
        }
        [HttpGet]
        public async Task<IActionResult> ProductAmenitiesList()
        {

            var values = await _productAmenitiesRepository.GetAllProductAmenities();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductAmenities(CreateProductAmenitiesDto createProductAmenitiesDto)
        {

           await _productAmenitiesRepository.CreateProductAmenities(createProductAmenitiesDto);
            return Ok("Amenities eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletProductAmenities(int id)
        {

          await  _productAmenitiesRepository.DeletProductAmenities(id);
            return Ok("Amenities silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductAmenities(UpdateProductAmenitiesDto updateProductAmenitiesDto)
        {

        await   _productAmenitiesRepository.UpdateProductAmenities(updateProductAmenitiesDto);
            return Ok("Kategori güncellendi");
        }
        [HttpGet("GetProductAmenities")]
        public async Task<IActionResult> GetProductAmenities(int id)
        {
            var value = await _productAmenitiesRepository.GetProductAmenities(id);
            return Ok(value);

        }

        [HttpGet("ResultProductAmenitieByStatusTrueDto")]
        public async Task<IActionResult> ResultProductAmenitieByStatusTrueDto(int id)
        {
            var value = await _productAmenitiesRepository.ResultProductAmenitieByStatusTrueDto(id);
            return Ok(value);

        }
    }
}
