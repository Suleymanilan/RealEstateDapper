using DocumentFormat.OpenXml.Office.CoverPageProps;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.AgentDtos;
using RealEstateDapper8.Repositories.AgentRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        private readonly IAgentRepository _agentRepository;

        public AgentController(IAgentRepository agentRepository)
        {
            _agentRepository = agentRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreatAgent(CreateAgentDto createAgentDto)
        {
         await   _agentRepository.CreateAgent(createAgentDto);
            return Ok("Agent Eklendi");

        }
        [HttpGet]
        public async Task<IActionResult> AgentList()
        {

            var values = await _agentRepository.GetAllAgent();
            return Ok(values);
        }
        [HttpDelete]
        public async Task<IActionResult> DeletAgent(int id)
        {

           await _agentRepository.DeleteAgent(id);

            return Ok("Agent slindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAgent(UpdateAgentDto updateAgentDto)
        {

        await  _agentRepository.UpdateAgent(updateAgentDto);
            return Ok("Agent Güncelendi");
        }
        [HttpGet("GetByAgent")]
        public async Task<IActionResult>GetAgent(int id)
        {

            var value=await _agentRepository.GetByAgent(id);
            return Ok(value);   
        }
    }
}
