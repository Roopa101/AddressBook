using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Addresses { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public string email { get; set; }
        public static List<Person> People = new List<Person>();
        public static Person person = new Person();
        Dictionary<string, List<Person>> PeopleDictionary = new Dictionary<string, List<Person>>();
        //Uc5 Use of AddPerson function to add multiple people
        private static void AddPerson()
        {


            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Emai:");
            person.email = Console.ReadLine();

            Console.Write("Enter Address: ");

            person.Addresses = Console.ReadLine();

            Console.Write("Enter City: ");
            person.city = Console.ReadLine();
            Console.Write("Enter State: ");
            person.state = Console.ReadLine();

            Console.Write("Enter zip:");
            person.zip = Convert.ToInt32(Console.ReadLine());



            People.Add(person);
        }
        private static void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address: " + person.Addresses);
            Console.WriteLine("city: " + person.city);
            Console.WriteLine("State : " + person.state);
            Console.WriteLine("Zip:" + person.zip);
            Console.WriteLine("-------------------------------------------");
        }
        public static void Main(String[] args)
        {

            Console.WriteLine("\tWelcome To Address Book ");
            Console.WriteLine("\tEnter add Command to add people");
            Console.WriteLine("\tEnter list Command to list people");
            Console.WriteLine("\tEnter edit Command to edit  people");
            Console.WriteLine("\tEnter remove Command to edit  people ");
            string command = "";
            while (command != "exit")
            {
                // Console.Clear();
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "add":
                        AddPerson();

                        break;
                    case "edit":
                        edit();
                        break;
                    case "remove":
                        RemovePerson();
                        break;
                    case "list":
                        ListPeople();
                        break;
                }
            }


        }
        private static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintPerson(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
        public static void edit()
        {
            Console.WriteLine("Enter the first name of the person you would like to edit.");
            string firstName = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person != null)
            {
                People.Remove(person);
                Console.WriteLine("Please detail again As you want changes!!!");
                Person person1 = new Person();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();
                Console.Write("Enter Emai:");
                person.email = Console.ReadLine();

                Console.Write("Enter Address: ");

                person.Addresses = Console.ReadLine();

                Console.Write("Enter City: ");
                person.city = Console.ReadLine();
                Console.Write("Enter State: ");
                person.state = Console.ReadLine();

                Console.Write("Enter zip:");
                person.zip = Convert.ToInt32(Console.ReadLine());



                People.Add(person);
                Console.ReadKey();

                return;
            }
            else
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();

                Console.ReadKey();

            }





        }
        private static void RemovePerson()
        {
            //use LINQ to query the list for the first person with the same first name as the first name the user entered.
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            if (person == null)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                People.Remove(person);
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}

