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
        public int Create(Contact contact)
        {
            _contactsContext.Add(contact);
            _contactsContext.SaveChanges();
            return contact.ContactId;
        }
        public int Update(Contact contact)
        {
            Contact? existingContact = _contactsContext.Contacts.Find(contact.ContactId);
            if (existingContact != null)
            {
                existingContact.FullName = contact.FullName;
                existingContact.Phone = contact.Phone;
                existingContact.Email = contact.Email;
                existingContact.IsFavorite = contact.IsFavorite;
            }
            return contact.ContactId;
        }
    }
}
