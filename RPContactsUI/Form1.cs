using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsClassLibrary;

namespace RPContactsUI
{
    public partial class Form1 : Form
    {
        static DataAccess db = new DataAccess();
        public static List<Contact> contacts;
        public Form1()
        {
            InitializeComponent();
            LoadContacts();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form2 formAddContact = new Form2(listView1);
            formAddContact.ShowDialog();
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                var result = MessageBox.Show("You are going to delete all records!",
                   "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    listView1.Items.Clear();
                    db.DeleteAllContacts();
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("List is empty, there is nothing to delete!",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("List is empty, there is nothing to delete!",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listView1.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Please select item from list to delete it!",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem eachItem in listView1.SelectedItems)
                {
                    int.TryParse(eachItem.SubItems[1].Text, out int selectedID);
                    listView1.Items.Remove(eachItem);
                    db.DeleteContactByID(selectedID);
                }

                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    ListViewItem item = listView1.Items[i];
                    item.SubItems[0].Text = (i + 1).ToString();
                }
            }
            else
            {
                MessageBox.Show("List is empty, there is nothing to delete!",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadContacts()
        {
            string[] contactListArray = new string[5];
            contacts = db.GetAllContacts();
            for (int i = 0; i < contacts.Count; i++)
            {
                contactListArray[0] = (i+1).ToString();
                contactListArray[1] = contacts[i].ID.ToString();
                contactListArray[2] = contacts[i].Name;
                contactListArray[3] = contacts[i].Job;
                contactListArray[4] = contacts[i].Email;
                listView1.Items.Add(new ListViewItem(contactListArray));
            }
        }
    }
}
