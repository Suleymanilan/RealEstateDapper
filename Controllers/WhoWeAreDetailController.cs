using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.WhoWeAreDetailDtos;
using RealEstateDapper8.Repositories.WhoWeAreDetail;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreDetailController : ControllerBase
    {
        private readonly IWhoWeAreDetailRepository _whoWeAreDetailRepository;

        public WhoWeAreDetailController(IWhoWeAreDetailRepository whoWeAreDetailRepository)
        {
            _whoWeAreDetailRepository = whoWeAreDetailRepository;
        }
        [HttpGet]
        public async Task<IActionResult>GetWhoWeAreDetailList()
        {

            var values=await _whoWeAreDetailRepository.GetAllWhoWeAreDetail();
            return Ok(values);
                
        }
        [HttpPut]
        public async Task<IActionResult>UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {

         await   _whoWeAreDetailRepository.UpdateWhoWeAreDetail(updateWhoWeAreDetailDto);
               return Ok("WhoWeAreDetail güncellendi ");
        }
        [HttpPost]
        public async Task<IActionResult> CrerateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {

          await  _whoWeAreDetailRepository.CreateWhoWeAreDetail(createWhoWeAreDetailDto);
            return Ok("WhoWeAreDetail eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletWhoWeAreDetail(int id)
        {

           await _whoWeAreDetailRepository.DeleteWhoWeAreDetail(id);
            return Ok("WhoWeAreDetail silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByWhoWeAreDetail(int id)
        {

            var value = await _whoWeAreDetailRepository.GetByIdWhoWeAreDetail(id);
            return Ok(value);
        }
    }
}
