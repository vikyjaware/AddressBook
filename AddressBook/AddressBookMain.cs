using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contacts> AddressBook=new List<Contacts>();
        public void AddNewContact()
        {
            Contacts contacts = new Contacts();
            Console.Write("Enter First Name : ");
            contacts.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            contacts.LastName = Console.ReadLine();
            Console.Write("Enter Address : ");
            contacts.Address = Console.ReadLine();
            Console.Write("Enter City : ");
            contacts.City = Console.ReadLine();
            Console.Write("Enter State : ");
            contacts.State = Console.ReadLine();
            Console.Write("Enter Zip Code : ");
            contacts.Zip = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Enter Phone Number : ");
            contacts.PhoneNumber =Convert.ToInt32 (Console.ReadLine());
            Console.Write("Enter Email : ");
            contacts.Email = Console.ReadLine();
            Console.WriteLine("\n" + contacts.FirstName
                            + "\n" + contacts.LastName
                            + "\n" + contacts.Address
                            + "\n" + contacts.City
                            + "\n" + contacts.State
                            + "\n" + contacts.Zip
                            + "\n" + contacts.PhoneNumber
                            + "\n" + contacts.Email);
            AddressBook.Add(contacts);
            Console.WriteLine("New Contact Successfully Added "+ contacts.FirstName + contacts.LastName);
        }
    }
}
