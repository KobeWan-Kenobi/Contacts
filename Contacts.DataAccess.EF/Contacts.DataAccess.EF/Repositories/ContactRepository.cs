using Contacts.DataAccess.EF.Context;
using Contacts.DataAccess.EF.Models;
using System;
using System.Collections.Generic;


namespace Contacts.DataAccess.EF.Repositories
{
    
    public class ContactRepository
    {
        private ContactsContext _contactsContext;
        public ContactRepository(ContactsContext contactsContext)
        {
            _contactsContext = contactsContext;
        }
        public int Create(Models.Contact contact)
        {
            int contactId;
            return contactId;
        }
    }
}
