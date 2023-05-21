using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace ContactsClassLibrary
{
    public class DataAccess
    {
        public void InsertContact(string name, string job, string email)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ContactBookDB")))
            {
                List<Contact> contacts = new List<Contact>();

                contacts.Add(new Contact() { Name = name, Job = job, Email = email });

                connection.Execute($"dbo.Insert_Contact @Name, @Job, @Email", contacts);
            }
        }
        public List<Contact> GetAllContacts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ContactBookDB")))
            {
                var output = connection.Query<Contact>($"dbo.Get_All_Contacts").ToList();

                return output;
            }
        }

        public List<Contact> GetLastContact()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ContactBookDB")))
            {
                var output = connection.Query<Contact>($"dbo.Get_Last_Contact").ToList();

                return output;
            }
        }

        public void DeleteAllContacts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ContactBookDB")))
            {

                connection.Execute($"dbo.Delete_All_Contacts");
            }
        }

        public void DeleteContactByID(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ContactBookDB")))
            {
                connection.Execute($"dbo.Delete_Contact_By_ID @ID", new { ID = id });
            }
        }

    }
}
