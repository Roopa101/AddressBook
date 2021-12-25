using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook
    {
        List<PersonDetail> addressList = new List<PersonDetail>();
        Dictionary<string, List<PersonDetail>> dictionary = new Dictionary<string, List<PersonDetail>>();
        public void AddContact(PersonDetail contact)
        {
            addressList.Add(contact);
        }
        public void EditContact(string name)
        {
            foreach (var contact in addressList)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    Console.WriteLine("Choose the field you want to edit : \n 1. First name \n 2. Last name \n 3. Address \n 4. City \n 5. State \n 6. Zip code \n 7. Phone Number \n 8. Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter you want to edit");
                            string first = Console.ReadLine();
                            contact.FirstName = first;
                            break;
                        case 2:
                            Console.WriteLine("Enter you want to edit");
                            string last = Console.ReadLine();
                            contact.LastName = last;
                            break;
                        case 3:
                            Console.WriteLine("Enter you want to edit");
                            string address = Console.ReadLine();
                            contact.Address = address;
                            break;
                        case 4:
                            Console.WriteLine("Enter you want to edit");
                            string city = Console.ReadLine();
                            contact.City = city;
                            break;
                        case 5:
                            Console.WriteLine("Enter you want to edit");
                            string state = Console.ReadLine();
                            contact.State = state;
                            break;
                        case 6:
                            Console.WriteLine("Enter you want to edit");
                            double zip = Convert.ToDouble(Console.ReadLine());                              
                            contact.Zip = zip;
                            break;
                        case 7:
                            Console.WriteLine("Enter you want to edit");
                            double phone = Convert.ToDouble( Console.ReadLine());
                            contact.PhoneNumber = phone;
                            break;
                        case 8:
                            Console.WriteLine("Enter you want to edit");
                            string email = Console.ReadLine();
                            contact.Email = email;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void DeleteContact(string name)
        {
            PersonDetail delete = new PersonDetail();
            foreach (var contact in addressList)
            {
                if (contact.FirstName == name || contact.LastName == name)
                {
                    delete = contact;
                }
            }
            addressList.Remove(delete);
            Console.WriteLine(name + " contact is deleted Permanently from the Address Book \n");
        }
        public void Display()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Contacts in Your Device : ");
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + "\t" + contact.LastName + "\t" + contact.City + "---" + contact.PhoneNumber);
            }
        }
        public void AddUniqueContact(string unique)
        {
            foreach (var contact in addressList)
            {
                if (addressList.Contains(contact))
                {
                    string uniqueName = Console.ReadLine();
                    dictionary.Add(uniqueName, addressList);
                }
            }
        }
        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter name in dictionary to display contact details");
            string name = Console.ReadLine().ToLower();
            foreach (var contacts in dictionary)
            {
                if (contacts.Key == name)
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact details of " + data.FirstName + "are : \n" + data.FirstName + " " + data.LastName + " " + data.Address + " " + data.City + " " + data.State + " " + data.Zip + " " + data.PhoneNumber + " " + data.Email);
                    }
                }
            }
            Console.WriteLine("Sorry this contact is already exists");
            return;
        }
        public void CheckDuplicateEntry()
        {
            Console.WriteLine("Enter the Name to Check whether the name is Duplicate or not");
            string checkD = Console.ReadLine();
            var person = addressList.Find(e => e.FirstName.Equals(checkD));
            if (person == null)
            {
                Console.WriteLine("The Name you are trying to check is Not in the Address Book");
            }
            else
            {
                Console.WriteLine("Error occured ! The Name : {0}, is already Exists in Address Book", checkD);
            }
        }
        public void PersonInCity()
        {
            Console.WriteLine("Enter the City name to Check Persons");
            string City = Console.ReadLine();
            List<PersonDetail> cityList = addressList.FindAll(e => e.City == City);
            foreach (var place in cityList)
            {
                Console.WriteLine("Found person {0} {1} in the Address Book, living in the City {2}", place.FirstName, place.LastName, place.City);
            }
        }
        public void ForState()
        {
            Console.WriteLine("Enter the State name to check Persons");
            string state = Console.ReadLine();
            List<PersonDetail> stateList = addressList.FindAll(e => e.State == state);
            foreach (var sta in stateList)
            {
                Console.WriteLine("Found the name of {0} {1} in the Address Book, living in the City {2}", sta.FirstName, sta.LastName, sta.State);
            }
        }
        public void CityCount()
        {
            Console.WriteLine("Enter the city name to check its count : ");
            string city = Console.ReadLine();
            List<PersonDetail> cityList = addressList.FindAll(e => e.City == city);
            Console.WriteLine("The Number of contact persons in the city {0} are {1}", city, cityList.Count());
        }
        public void StateCount()
        {
            Console.WriteLine("Enter the state name to check its count : ");
            string state = Console.ReadLine();
            List<PersonDetail> stateList = addressList.FindAll(e => e.State == state);
            Console.WriteLine("The number of contact persons in the state {0} are {1}", state, stateList.Count());
        }
        public void AddressBookSorting()
        {
            Console.WriteLine("Enter the Address Book name that you want to sort : ");
            string addressBookName = Console.ReadLine();
            if (dictionary.ContainsKey(addressBookName))
            {
                dictionary[addressBookName].Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
                Console.WriteLine("After Sorting alphabetically, The Address Book is arranged as : ");
                Display();
            }
            else
            {
                Console.WriteLine("The {0} Addressbook does not exist. Please Enter a Valid Addressbook Name. ", addressBookName);
            }
        }
        public void Sorting()
        {
            {
                Console.WriteLine("Enter the Address Book name that you want to sort : ");
                string addressBookName = Console.ReadLine();
                Console.WriteLine("How do you want the Sort the Addressbook : \n 1. Sort based on City \n 2. Sort based on State \n 3. Sort based on Zip");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        dictionary[addressBookName].Sort((x, y) => x.City.CompareTo(y.City));
                        Console.WriteLine("After Sorting alphabetically, The Address Book is arranged as : ");
                        Display();
                        break;
                    case 2:
                        dictionary[addressBookName].Sort((x, y) => x.State.CompareTo(y.State));
                        Console.WriteLine("After Sorting alphabetically, The Address Book is arranged as : ");
                        Display();
                        break;
                    case 3:
                        dictionary[addressBookName].Sort((x, y) => x.Zip.CompareTo(y.Zip));
                        Console.WriteLine("After Sorting alphabetically, The Address Book is arranged as : ");
                        Display();
                        break;
                }
            }
        }
        public void ReadFile()
        {
            Console.WriteLine("The Contact details in the file after reading : \n ");
            string filePath = @"C:\Users\Dell\Documents\AddressBookProgram\AddressBook\AddressBookSystem\AddressBookSystem\File\File.txt";
            string text = File.ReadAllText(filePath);
            Console.WriteLine(text);
        }
        public void WritingUsingStreamWriter()
        {
            Console.WriteLine("\n The Contact details in the file after writing : ");
            String filePath = @"C:\Users\Dell\Documents\AddressBookProgram\AddressBook\AddressBookSystem\AddressBookSystem\File\File.txt";
            using (StreamWriter writer = File.AppendText(filePath))
            {

                writer.WriteLine("FirstName: Roopa\n LastName: Jamadar \n Address: Khandal \n City: Kalaburgi \n  State: Karnataka \n PhoneNumber:9901123984\n Zip:585401 \n Email: roopajamadar14@gmail.com     \nSNN : 991989999");
                writer.Close();
                Console.WriteLine(File.ReadAllText(filePath));
            }
        }
    }
}