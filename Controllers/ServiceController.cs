using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.CategoryDtos;
using RealEstateDapper8.Dtos.ServiceDtos;
using RealEstateDapper8.Repositories.CategoryRepository;
using RealEstateDapper8.Repositories.ServiceRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {

            var values = await _serviceRepository.GetAllService();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {

          _serviceRepository.CrerateService(createServiceDto);   
            return Ok("servis eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletService(int id)
        {

           _serviceRepository.DeleteService(id); 
            return Ok("Servis silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {

           _serviceRepository.UpdateService(updateServiceDto);  
            return Ok("Servis güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            var value = await _serviceRepository.GetService(id);
            return Ok(value);

        }
    }
}
