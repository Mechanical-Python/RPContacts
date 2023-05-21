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
    public partial class Form2 : Form
    {
        static DataAccess db = new DataAccess();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(ListView listViewForm1)
        {
            InitializeComponent();
            ListViewForm2 = listViewForm1;
        }

        public ListView ListViewForm2;
        public ListViewItem listViewItem = null;
        public string[] listViewArray = new string[5];
        public Random random = new Random();

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(textBox_Name.Text) && !string.IsNullOrEmpty(textBox_Job.Text) && !string.IsNullOrEmpty(textBox_Email.Text))
            {

                db.InsertContact(textBox_Name.Text, textBox_Job.Text, textBox_Email.Text);
                List<Contact> lastContact = db.GetLastContact();

                int contactsCount = ListViewForm2.Items.Count;

                for (int i = 0; i < lastContact.Count; i++)
                {
                    listViewArray[0] = (contactsCount + 1).ToString();
                    listViewArray[1] = lastContact[i].ID.ToString();
                    listViewArray[2] = lastContact[i].Name;
                    listViewArray[3] = lastContact[i].Job;
                    listViewArray[4] = lastContact[i].Email;
                }

                AddItems(listViewArray);
                ListViewForm2.Items.Add(listViewItem);
                

                textBox_Name.Clear();
                textBox_Job.Clear();
                textBox_Email.Clear();
            }
            else
            {
                MessageBox.Show("Please fill all fields!",
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public ListViewItem AddItems(string[] itemList)
        {
            listViewItem = new ListViewItem(itemList);
            return listViewItem;
        }
    }
}
