using Contact.API.Infrastructure;
using Contact.API.Models;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public static List<ContactDto> AllContacts { get; set; }
        = new List<ContactDto>()
        {
            new ContactDto()
            {
                Id = new Random().Next(1, 100000),
                 Firstname = "Ali",
                 Lastname = "Aliyev"
            },
            new ContactDto()
            {
                Id = new Random().Next(1, 100000),
                 Firstname = "Aysel",
                 Lastname = "Aliyeva"
            },
            new ContactDto()
            {
                Id = new Random().Next(1, 100000),
                 Firstname = "Tural",
                 Lastname = "Mammadov"
            }
        };

        public void Add(API.Models.ContactDto contact)
        {
            AllContacts.Add(contact);
        }

        public void Delete(int id)
        {
            var item = GetContactById(id);
            if (item != null)
            {
                AllContacts.Remove(item);
            }
        }

        public List<API.Models.ContactDto> GetAll()
        {
            return AllContacts;
        }

        public API.Models.ContactDto GetContactById(int id)
        {
            return AllContacts.SingleOrDefault(c => c.Id == id);
        }
    }
}