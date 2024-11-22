using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Repositories.ProductRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductDetailController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet("GetProductDetailByID")]
        public async Task<IActionResult> GetProductDetailByID(int id)
        {

            var value = await _productRepository.GetProductDetailByID(id);
            return Ok(value);
        }
    }
}
