using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsClassLibrary
{
    public class ContactService
    {
        public readonly IDataAccess _dataAccess;

        public ContactService(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void InsertContact(Contact contact)
        {
            _dataAccess.InsertContact(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return _dataAccess.GetAllContacts();
        }

        public List<Contact> GetLastContact()
        {
            return _dataAccess.GetLastContact();
        }

        public void DeleteAllContacts()
        {
            _dataAccess.DeleteAllContacts();
        }

        public void DeleteContactByID(int id)
        {
            _dataAccess.DeleteContactByID(id);
        }
    }
}
