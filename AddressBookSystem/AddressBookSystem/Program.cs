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
            while (flag)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Add Contacts \n 3. Edit Contact \n 4. Delete Contact \n 5. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the Contact details of FirstName, LastName, Address, City, State, Zip, Ph.no, Email");
                        ContactBook contact = new ContactBook()
                        {
                            FirstName = Console.ReadLine(),
                            LastName = Console.ReadLine(),
                            Address = Console.ReadLine(),
                            City = Console.ReadLine(),
                            State = Console.ReadLine(),
                            Zip = Console.ReadLine(),
                            PhoneNumber = Console.ReadLine(),
                            Email = Console.ReadLine(),
                        };
                        break;
                    case 2:
                        Console.WriteLine("Enter the contact to be added : ");
                        ContactBook con = new ContactBook();
                        con.AddContact();
                        con.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the contact which you want to Edit");
                        string name = Console.ReadLine();
                        ContactBook edit = new ContactBook();
                        edit.AddContact();
                        edit.EditContact(name);
                        edit.Display();
                        break;
                    case 4:
                        Console.WriteLine("Enter the contact you want to delete :");
                        string detail = Console.ReadLine();
                        ContactBook delete = new ContactBook();
                        delete.AddContact();
                        delete.DeleteContact(detail);
                        delete.Display();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}