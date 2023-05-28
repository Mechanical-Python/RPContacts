using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ContactsClassLibrary
{
    public class SQLDataAccess : IDataAccess
    {
        readonly string connectionString = Helper.CnnVal("ContactBookDB");

        public void DeleteAllContacts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {

                connection.Execute($"dbo.Delete_All_Contacts");
            }
        }

        public void DeleteContactByID(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {

                connection.Execute($"dbo.Delete_All_Contacts");
            }
        }

        public List<Contact> GetAllContacts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var output = connection.Query<Contact>($"dbo.Get_All_Contacts").ToList();

                return output;
            }
        }

        public List<Contact> GetLastContact()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                var output = connection.Query<Contact>($"dbo.Get_Last_Contact").ToList();

                return output;
            }
        }

        public void InsertContact(Contact contact)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                List<Contact> newContact = new List<Contact>();

                newContact.Add(new Contact() { Name = contact.Name, Job = contact.Job, Email = contact.Job });

                connection.Execute($"dbo.Insert_Contact @Name, @Job, @Email", newContact);
            }
        }
    }
}
