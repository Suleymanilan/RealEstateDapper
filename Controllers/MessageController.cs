using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Repositories.MessageRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _messageRepository;

        public MessageController(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetInBoxLast3MessageListReceiver(int id)
        {

            var values = await _messageRepository.GetInBoxLast3MessageListReceiverDto(id);
            return Ok(values);
        }
    } 
}
