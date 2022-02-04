// See https://aka.ms/new-console-template for more information
using AddressBook;
Console.WriteLine("Welcome to the Address Book problem statement!");

bool var = true;
            AddressBookMain addressBook = new AddressBookMain();
while (var)
{
Console.WriteLine("Select the operation from following..\n "+ "Enter 1 for Adding a new contact\n "+ "Enter 2 for editing an existing contact\n");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            addressBook.AddNewContact();
            break;
        case 2:
            Console.WriteLine("Enter First Name To Edit Contact : ");
            string FirstName = Console.ReadLine();
            addressBook.EditContact(FirstName);
            break;
        default:
            var=false;
            Console.WriteLine("Enter Correct Option...");
            break;
    }
}