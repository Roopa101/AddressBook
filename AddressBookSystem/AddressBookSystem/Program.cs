using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        Dictionary<string, List<PersonDetail>> persondic = new Dictionary<string, List<PersonDetail>>();
        List<PersonDetail> personlist1 = new List<PersonDetail>();
        List<PersonDetail> people = new List<PersonDetail>();
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Welcome to Address Book program");
            char ans;
            do
            {
                Console.WriteLine("1)Add Contact   2)Show Contact   3)Edit Contact   4)Delete Contact");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.Create();
                        break;
                    case 2:
                        program.Show();
                        break;
                    case 3:
                        program.Edit();
                        break;
                    case 4:
                        program.Delete();
                        break;
                }
                Console.Write("Want to Continue(Y/N) : ");
                ans = Convert.ToChar(Console.ReadLine());
            } while (ans == 'Y' || ans == 'y');

            Console.ReadKey();
        }
        public Dictionary<string, List<PersonDetail>> Create()//create new contact
        {
            List<PersonDetail> personlist = new List<PersonDetail>();
            Console.Write("Enter Address book name : ");
            string addressbkName = Console.ReadLine();
            Console.Write("Enter number of how many contacts you want to create : ");
            int countContact = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= countContact)
            {
                PersonDetail personobj = new PersonDetail();
                Console.WriteLine("\nEnter person {0} details ", i);
                Console.Write("\nEnter First Name : ");
                personobj.fisrtName = Console.ReadLine();
                Console.Write("Enter Last Name : ");
                personobj.lastName = Console.ReadLine();
                Console.Write("Enter Address : ");
                personobj.address = Console.ReadLine();
                Console.Write("Enter City : ");
                personobj.city = Console.ReadLine();
                Console.Write("Enter State : ");
                personobj.state = Console.ReadLine();
                Console.Write("Enter phone number : ");
                personobj.phoneNumber = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Zip : ");
                personobj.zip = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Email : ");
                personobj.email = Console.ReadLine();
                bool duplicate = personlist.Any(x => x.fisrtName.Equals(personobj.fisrtName));
                if (duplicate == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Contact with same firstname already present in address book.Try to give another name");
                }
                else
                {
                    personlist.Add(personobj);
                    people.Add(personobj);
                    Console.WriteLine("\nContact created successfully");
                    Console.WriteLine("----------------------------------------------------------------------");
                    i++;
                }

            }
            persondic.Add(addressbkName, personlist);
            return persondic;
        }
        public void Show()
        {
            // Create();
            if (persondic.Count == 0)
            {
                Console.WriteLine("Your address book is empty");
            }
            else
                foreach (KeyValuePair<string, List<PersonDetail>> keyValue in persondic)
                {
                    Console.Write("Address Book name is : " + keyValue.Key);
                    foreach (var contact in keyValue.Value)//showing items in list
                    {
                        Console.WriteLine("\nPerson details are :");
                        Console.WriteLine("\nFirstName : {0} \nLastName : {1} \nAddress : {2} \nCity : {3} \nState : {4} \nPhone Number : {5} \nZip : {6} \nEmail : {7}",
                      contact.fisrtName, contact.lastName, contact.address, contact.city, contact.state, contact.phoneNumber,
                       contact.zip, contact.email);
                        Console.WriteLine("----------------------------------------------------------------------");
                    }
                }

        }

        public void Edit()
        {
            Console.WriteLine("Enter FirstName of person which contact wants to edit");
            string firstName1 = Console.ReadLine();
            PersonDetail personobj = people.FirstOrDefault(x => x.fisrtName == firstName1);
            if (people.Contains(personobj))
            {
                Console.WriteLine("1)FirstName 2)LastName 3)Address 4)City 5)State 6)Phone Number 7)Zip 8)Email");
                Console.Write("Enter number from above list which you wants to edit :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter First Name : ");
                        personobj.fisrtName = Console.ReadLine();

                        break;
                    case 2:
                        Console.Write("Enter Last Name : ");
                        personobj.lastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Enter Address : ");
                        personobj.address = Console.ReadLine();
                        EditContact(personobj);
                        break;
                    case 4:
                        Console.Write("Enter City : ");
                        personobj.city = Console.ReadLine();
                        EditContact(personobj);
                        break;
                    case 5:
                        Console.Write("Enter State : ");
                        personobj.state = Console.ReadLine();
                        EditContact(personobj);
                        break;
                    case 6:
                        Console.Write("Enter phone number : ");
                        personobj.phoneNumber = Convert.ToDouble(Console.ReadLine());
                        EditContact(personobj);
                        break;
                    case 7:
                        Console.Write("Enter Zip : ");
                        personobj.zip = Convert.ToDouble(Console.ReadLine());
                        EditContact(personobj);
                        break;
                    case 8:
                        Console.Write("Enter Email : ");
                        personobj.email = Console.ReadLine();
                        EditContact(personobj);
                        break;
                    default:
                        Console.WriteLine("Please enter valid numbers");
                        break;
                }
                Console.WriteLine("\nContact Updated successfully");
                Console.WriteLine("----------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }
        public void EditContact(PersonDetail person)
        {
            people.Add(person);
        }
        public void Delete()
        {
            Console.Write("Enter the first name of the person you want to remove : ");
            string firstName1 = Console.ReadLine();
            foreach (KeyValuePair<string, List<PersonDetail>> data in persondic)
            {
                foreach (PersonDetail contact in data.Value)
                {
                    if (contact.fisrtName == firstName1)
                    {
                        Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
                        if (Console.ReadKey().Key == ConsoleKey.Y)
                            data.Value.Remove(contact);
                        Console.WriteLine("\nContact deleted successfully");
                        Console.WriteLine("---------------------------------------------------");
                        return;
                    }

                }

            }
        }

    }
}
