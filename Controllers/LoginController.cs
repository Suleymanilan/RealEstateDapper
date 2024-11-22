using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.LoginDtos;
using RealEstateDapper8.Models.DapperContext;
using RealEstateDapper8.Tools;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult>SignIn(CreateLoginDto createLogin)
        {
            string query = "Select * From AppUsers Where UserName=@username and Password=@password";
            string query2 = "Select UserID From AppUsers Where UserName=@username and Password=@password";
            var parameters = new DynamicParameters();
            parameters.Add("@username", createLogin.Username);
            parameters.Add("@password", createLogin.Password);
            using (var connection = _context.CreateConnection())
            {
            var values=await connection.QueryFirstOrDefaultAsync<CreateLoginDto>(query,parameters);
            var values2=await connection.QueryFirstOrDefaultAsync<GetAppUserDto>(query,parameters);
                if (values != null)
                {
                    GetCheckAppUserViewModel model = new GetCheckAppUserViewModel();
                    model.Username= values.Username;
                    model.Id = values2.UserID;
                    var token = JwtTokenGenerator.GenerateToken(model);
                    return Ok(token);
                }
                else
                {
                    return Ok("Başarısız");
                }
            }

        }
    }
}
