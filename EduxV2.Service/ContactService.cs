using EduxV2.Data;
using EduxV2.Repo;
using System;
using System.Collections.Generic;

namespace EduxV2.Service
{
    public class ContactService : IContactService
    {
        private IRepository<Contact> contactRepository;

        public ContactService(IRepository<Contact> contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        public IEnumerable<Contact> GetContacts()
        {
            return contactRepository.GetAll();
        }

        public IEnumerable<Contact> GetCandidateContacts()
        {
            return contactRepository.GetMany(c=>c.ContactStatus == ContactStatus.Candidate && c.ContactType == ContactType.Student, "Activities", "Activities.ActivityNextStep", "Activities.Staff");
        }

        public Contact GetContact(string id)
        {
            return contactRepository.Get(id);
        }

        public void InsertContact(Contact contact)
        {
            contactRepository.Insert(contact);
        }
        public void UpdateContact(Contact contact)
        {
            contactRepository.Update(contact);
        }

        public void DeleteContact(string id)
        {
            Contact contact = GetContact(id);
            contactRepository.Remove(contact);
            contactRepository.SaveChanges();
        }
    }
    public interface IContactService
    {
        IEnumerable<Contact> GetContacts();
        IEnumerable<Contact> GetCandidateContacts();
        Contact GetContact(string id);
        void InsertContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(string id);
    }
}
