using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contacts> AddressBook = new List<Contacts>();
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
            contacts.Zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Phone Number : ");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("New Contact Successfully Added : " + contacts.FirstName + contacts.LastName);
        }
        public void EditContact(string FirstName)
        {
            Contacts contact = new Contacts();

            foreach (var data in AddressBook)
            {
                if (data.FirstName == FirstName)
                {
                    contact = data;
                    Console.WriteLine("\n 1. First name\n 2. Last name\n 3. Address\n 4. City\n 5. State\n 6. Zip\n 7. Phone number\n 8. Email\n 9. Exit");
                    bool flag = true;
                    while (flag)
                    {

                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter the First name");
                                contact.FirstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the Last name");
                                contact.LastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the Address");
                                contact.Address = Convert.ToString(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Enter the City");
                                contact.City = Convert.ToString(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter the State");
                                contact.State = Convert.ToString(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter the Zip Code");
                                contact.Zip = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 7:
                                Console.WriteLine("Enter the Phone Number");
                                contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 8:
                                Console.WriteLine("Enter the Email");
                                contact.Email = Convert.ToString(Console.ReadLine());
                                break;
                            case 9:
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("Enter Correct option...");
                                break;
                        }
                        Display();
                        return;
                    }

                }
            }
        }


        public void Display()
        {
            foreach (var data in AddressBook)
            {
                Console.WriteLine("Created Contact :\n" + data.FirstName
                            + "\n" + data.LastName
                            + "\n" + data.Address
                            + "\n" + data.City
                            + "\n" + data.State
                            + "\n" + data.Zip
                            + "\n" + data.PhoneNumber
                            + "\n" + data.Email);
            }
        }
    }
}
