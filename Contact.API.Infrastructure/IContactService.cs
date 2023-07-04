using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Infrastructure
{
    public interface IContactService
    {
        ContactDto GetContactById(int id);
        List<ContactDto> GetAll();
        void Add(ContactDto contact);
        void Delete(int id);
    }
}
