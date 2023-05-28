using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsClassLibrary
{
    public class Contact
    {
        public int ID { get; }
        public string Name { get; set; }
        public string  Job { get; set; }
        public string  Email { get; set; }

        public Contact()
        {

        }
    }
}
