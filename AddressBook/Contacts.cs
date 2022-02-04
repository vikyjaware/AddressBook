using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public void CreateContact()
        {
            Console.WriteLine("Enter the First Name");
            this.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            this.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            this.Address = Console.ReadLine();
            Console.WriteLine("Enter the City");
            this.City = Console.ReadLine();
            Console.WriteLine("Enter the State");
            this.State = Console.ReadLine();
            Console.WriteLine("Enter the Zip");
            this.Zip =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter the PhoneNumber");
            this.PhoneNumber = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter the Email");
            this.Email = Console.ReadLine();

            Console.WriteLine(FirstName + LastName + " Contact Created");
        }
    }
}
