using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.AgentDtos;
using RealEstateDapper8.Dtos.AppUsersDto;
using RealEstateDapper8.Repositories.AppUserRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IAppUserRepository _appUserRepository;

        public AppUsersController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreatAppUser(CreateAppUserDto createAppUserDto)
        {
         await  _appUserRepository.CreateAppUser(createAppUserDto);
            return Ok("User Eklendi");

        }
        [HttpGet]
        public async Task<IActionResult> ResultAppUserList()
        {

            var values = await _appUserRepository.GetAllAppUser();
            return Ok(values);
        }
        [HttpDelete]
        public async Task<IActionResult> DeletAppUser(int id)
        {

        await  _appUserRepository.DeleteAppUser(id);

            return Ok("User slindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAppUser(UpdateAppUserDto updateAppUserDto)
        {

        await   _appUserRepository.UpdateAppUser(updateAppUserDto);
            return Ok("User Güncelendi");
        }
        [HttpGet("GetByAppUser")]
        public async Task<IActionResult> GetAppUser(int id)
        {

            var value = await _appUserRepository.GetByAppUser(id);
            return Ok(value);
        }
    }
}
