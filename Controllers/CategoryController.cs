using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.CategoryDtos;
using RealEstateDapper8.Repositories.CategoryRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {

            var values = await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {

          await  _categoryRepository.CreateCategory(createCategoryDto);
            return Ok("Kategori eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletCategory(int id)
        {

          await  _categoryRepository.DeletCategory(id);
            return Ok("Kategory silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {

          await  _categoryRepository.UpdateCategory(updateCategoryDto);
            return Ok("Kategori güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>GetCategory(int id)
        {
          var value= await _categoryRepository.getCategory(id);    
            return Ok(value);   

        }


      
    }
}
