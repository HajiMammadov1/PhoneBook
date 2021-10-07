using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBookApp
{
    class PhoneBook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name} \nNumber: {contact.Number}");

        }
        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
        
        public void DisplayContact(string number)
        {
            var contact = _contacts.FirstOrDefault(c => c.Number == number);
            if (contact == null)
            {
                Console.WriteLine("Contact is not founded");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContact()
        {
            DisplayContactsDetails(_contacts);
        }
        public void DisplayMatchingContact(string searchPhrase)
        {
            var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);

        }
    }
}
