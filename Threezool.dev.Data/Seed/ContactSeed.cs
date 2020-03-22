using System.Collections.Generic;
using Threezool.dev.Data.Models;

namespace Threezool.dev.Data.Seed
{
    public static class ContactSeed
    {
        public static List<Contact> GetContactSeedData()
        {
            return new List<Contact>
            {
                new Contact
                {
                    Id = 1,
                    FirstName = "Kim",
                    LastName = "Böndergaard",
                    Email = "contact@threezool.dev",
                    ContactType = ContactType.Consultant
                },
                new Contact
                {
                    Id = 1,
                    FirstName = "Kim",
                    LastName = "Böndergaard",
                    Email = "threezool@gmail.com",
                    ContactType = ContactType.Private
                }
            };
        }
    }
}