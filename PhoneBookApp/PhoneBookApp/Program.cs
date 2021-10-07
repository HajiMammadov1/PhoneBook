using System;

namespace PhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Select opeartion");
            Console.WriteLine("1.Add contact");
            Console.WriteLine("2.Display contact by number");
            Console.WriteLine("3.View all contacts");
            Console.WriteLine("4.Search for contacts for a given name");
            Console.WriteLine("Press 'x to exit");
            var userinput = Console.ReadLine();

            var phoneBook = new PhoneBook();
            //PhoneBook phone = new PhoneBook();
            while (true)
            {
                switch (userinput)
                {
                    case "1":
                        Console.Write("Contact name:");
                        var name = Console.ReadLine();
                        Console.Write("Contact number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Contact number to search: ");
                        var searchNumber = Console.ReadLine();

                        phoneBook.DisplayContact(searchNumber);
                        break;
                    case "3":
                        phoneBook.DisplayAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Search phrase:");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContact(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select valid operation");
                        break;
                }
                Console.WriteLine("Select operation");
                userinput = Console.ReadLine();
            }
            

        }
    }
}
