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
            Console.WriteLine("Welcome to Address Book Program");
            {
                bool flag = true;
                Contact contact = new Contact();
                AddressBook addressBook = new AddressBook();
                while (flag)
                {
                    Console.WriteLine("Welcome to the Address Book Program");
                    Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contacts \n 3. Edit Contacts \n 4. Exit");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email : ");
                            contact = new Contact()
                            {
                                FirstName = Console.ReadLine(),
                                LastName = Console.ReadLine(),
                                Address = Console.ReadLine(),
                                City = Console.ReadLine(),
                                State = Console.ReadLine(),
                                Zip =Convert.ToInt32( Console.ReadLine()),
                                MobileNumber = Convert.ToDouble( Console.ReadLine()),
                                Email = Console.ReadLine(),
                            };
                            break;
                        
                        case 2:
                            Console.WriteLine("Enter the Contact Information to Add, in form of FirstName, LastName, Addr, City, State, Zip, Ph.No, Email.");
                            contact = new Contact()
                            {
                                FirstName = Console.ReadLine(),
                                LastName = Console.ReadLine(),
                                Address = Console.ReadLine(),
                                City = Console.ReadLine(),
                                State = Console.ReadLine(),
                                Zip = Convert.ToInt32(Console.ReadLine()),
                                MobileNumber = Convert.ToDouble(Console.ReadLine()),
                                Email = Console.ReadLine(),
                            };
                            
                            addressBook.AddContact(contact);
                            addressBook.Display();
                            break;
                        
                        case 3:
                            Console.WriteLine("Enter the Contact Name to  Edit: ");
                            string name = Console.ReadLine();
                            addressBook.EditContact(name);
                            Console.WriteLine("Contact is Edited Sucsessfully");
                            addressBook.Display();
                            break;
                        case 4:
                            flag = false;
                            break;
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}    