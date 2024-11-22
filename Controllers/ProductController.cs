using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.ProductDtos;
using RealEstateDapper8.Repositories.ProductRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProduct();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {

         await   _productRepository.CrerateProduct(createProductDto);
            return Ok("Product Eklendi");
        }

        [HttpGet("GetProduct")]
        public async Task<IActionResult> GetProduct(int id)
        {

            var value = await _productRepository.GetProduct(id);
            return Ok(value);
        }

      


        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {

         await   _productRepository.UpdateProduct(updateProductDto);
            return Ok("Product güncellendi");
        }
        [HttpGet("GetAllProductEmployeeCategory")]
        public async Task<IActionResult> GetAllProductEmployeeCategory()
        {

            var values = await _productRepository.GetAllProductEmployeeCategory();
            return Ok(values);
        }
        [HttpDelete]
        public async Task<IActionResult> DeletProduct(int id)
        {

          await  _productRepository.DeleteProduct(id);
            return Ok("Product silindi");
        }
        [HttpGet("ProductDealOfDayStatusChangeToTrue/{id}")]
        public async Task<IActionResult>ProductDealOfDayStatusChangeToTrue(int id)
        {
         await   _productRepository.ProductDealOfDayStatusChangeToTrue(id);
            return Ok("İlan Güncellendi");
        }
        [HttpGet("ProductDealOfDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ProductDealOfDayStatusChangeToFalse(int id)
        {
           await _productRepository.ProductDealOfDayStatusChangeToFalse(id);
            return Ok("İlan Güncellendi");
        }
        [HttpGet("GetLast5ProductAsync")]
        public async Task<IActionResult> GetLast5ProductAsync()
        {

            var values=await _productRepository.GetLast5ProductAsync();
            return Ok(values);
        }
        [HttpGet("ProductAdvertListByAgentTrue")]
        public async Task<IActionResult> ProductAdvertListByAgentTrue(int id)
        {

            var values = await _productRepository.ProductAdvertListByAgentTrue(id);
            return Ok(values);
        }

        [HttpGet("ProductAdvertListByAgentFalse")]
        public async Task<IActionResult> ProductAdvertListByAgentFalse(int id)
        {

            var values = await _productRepository.ProductAdvertListByAgentFalse(id);
            return Ok(values);
        }
        [HttpGet("ResultProductSearchList")]
        public async Task<IActionResult> ResultProductSearchList(string searchKeyValue, int propertyCategoryId, string city)
        {

            var values = await _productRepository.ResultProductSearchList(searchKeyValue,propertyCategoryId, city);
            return Ok(values);
        }
        [HttpGet("GetDealOfDayTrueProductByCategory")]
        public async Task<IActionResult> GetDealOfDayTrueProductByCategory()
        {

            var values = await _productRepository.GetDealOfDayTrueProductByCategory();
            return Ok(values);
        }
        [HttpGet("GetLast3ProductAsync")]
        public async Task<IActionResult> GetLast3ProductAsync()
        {

            var values = await _productRepository.GetLast3ProductAsync();
            return Ok(values);
        }
    }
}


