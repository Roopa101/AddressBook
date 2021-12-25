using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            PersonDetail contact = new PersonDetail();
            AddressBook addressBook = new AddressBook();
            while (flag)
            {
                Console.WriteLine("Welcome to the Address Book Program");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contacts \n 3. Edit Contacts \n 4. Delete Contact \n 5. Add Multiple Contact \n 6. Add Unique Contact \n 7. Check For Duplicate Entry \n 8. Check for Person in City or State \n 9. View Persons by City or State \n 10. Number of persons by City or State \n 11. AddressBookSorting \n 12.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email : ");
                        contact = new PersonDetail()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Convert.ToDouble( Console.ReadLine()),
                            PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the Contact Information to Add, in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        contact = new PersonDetail()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Convert.ToDouble( Console.ReadLine()),
                            PhoneNumber = Convert.ToDouble( Console.ReadLine()),
                            Email = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        addressBook.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the Contact Name to  Edit: ");
                        string name = Console.ReadLine();
                        addressBook.EditContact(name);
                        Console.WriteLine("Contact is Edited Successfully");
                        addressBook.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the Contact Name to deleted : ");
                        string detail = Console.ReadLine();
                        addressBook.DeleteContact(detail);
                        addressBook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Contact Information to Add, in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                        contact = new PersonDetail()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Convert.ToDouble( Console.ReadLine()),
                            PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                            Email = Console.ReadLine(),
                        };
                        addressBook.AddContact(contact);
                        Console.WriteLine("Contact is Saved");
                        addressBook.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        string unique = Console.ReadLine();
                        addressBook.AddUniqueContact(unique);
                        addressBook.DisplayUniqueContacts();
                        break;
                    case 7:
                        addressBook.CheckDuplicateEntry();
                        break;
                    case 8:
                        Console.WriteLine("Select the options to Check\n 1. City \n 2. State");
                        int number = Convert.ToInt32(Console.ReadLine());
                        if (number == 1)
                        {
                            addressBook.PersonInCity();
                        }
                        if (number == 2)
                        {
                            addressBook.ForState();
                        }
                        break;
                    case 9:
                        break;
                    case 10:
                        Console.WriteLine("Select the options to Check\n 1. CityCount \n 2. StateCount");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num == 1)
                        {
                            addressBook.CityCount();
                        }
                        if (num == 2)
                        {
                            addressBook.StateCount();
                        }
                        break;
                    case 11:
                        addressBook.AddressBookSorting();
                        break;
                    case 12:
                        flag = false;
                        break;
                }
            }
        }
    }
}
