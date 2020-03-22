using Threezool.dev.Data.Models;
using Threezool.dev.Data.Repository;

namespace Threezool.dev.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> contactService;

        public ContactService(IRepository<Contact> contactService)
        {
            this.contactService = contactService;
        }
    }
}