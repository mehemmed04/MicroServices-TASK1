using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public IContactService _contactService { get; }


        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{id}")]
        public ContactDto Get(int id)
        {
            return _contactService.GetContactById(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.Delete(id);
            return NoContent();
        }

        [HttpGet("")]
        public List<ContactDto> GetAll()
        {
            return _contactService.GetAll();
        }

        [HttpPost]
        public ContactDto Add(ContactDto dto)
        {
            _contactService.Add(dto);
            return dto;
        }
    }
}
