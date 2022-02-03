using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contacts> addressbook=new List<Contacts>();
        public void CreateContact()
        {
            Contacts contacts = new Contacts();
            Console.WriteLine("Enter FirstName");
            contacts.FirstName = Console.ReadLine();
        }
    }
}
