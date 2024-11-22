using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateDapper8.Dtos.ContactDtos;
using RealEstateDapper8.Repositories.ContactRepository;

namespace RealEstateDapper8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _contactRepository.GetAllContact();
            return Ok(values);
        }
        [HttpGet("Last4Contact")]
        public async Task<IActionResult> Last4Contact()
        {
            var values = await _contactRepository.Last4Contact();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {

        await  _contactRepository.CreateContact(createContactDto);
            return Ok("measaj eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletContact(int id)
        {

          await  _contactRepository.DeletContact(id);
            return Ok("measj silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
        {

         await  _contactRepository.UpdateContact(updateContactDto);
            return Ok("measj güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value = await _contactRepository.GetByContact(id);
            return Ok(value);

        }
    }
}
