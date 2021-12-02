using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {

        List<Contact> addressList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            addressList.Add(contact);
        }
        public void Display()
        {
            foreach (var contact in addressList)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.City);
                Console.WriteLine("State : " + contact.State);
                Console.WriteLine("Zip : " + contact.Zip);
                Console.WriteLine("PhoneNumber : " + contact.MobileNumber);
                Console.WriteLine("Email : " + contact.Email);
                Console.WriteLine("Contact is Added Successfully");
            }
        }
    }
}
