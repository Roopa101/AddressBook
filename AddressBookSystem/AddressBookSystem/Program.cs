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
                while (flag)
                {
                    Console.WriteLine("Welcome to Address Book Program");
                    Console.WriteLine("Enter what you want to do : \n 1. Create Contacts \n 2. Exit");
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
                                Zip = Convert.ToInt32( Console.ReadLine()),
                                MobileNumber = Convert.ToDouble( Console.ReadLine()),
                                Email = Console.ReadLine(),
                            };
                            break;
                        case 2:
                            flag = false;
                            break;
                    }
                }
            }
        }
    }
}
    