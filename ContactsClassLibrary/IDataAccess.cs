using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsClassLibrary
{
    public interface IDataAccess
    {
        void InsertContact(Contact contact);
        List<Contact> GetAllContacts();
        List<Contact> GetLastContact();
        void DeleteAllContacts();
        void DeleteContactByID(int id);
    }
}
