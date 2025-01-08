using Contacts.Models;
using System.Text.Json;

namespace Contacts.Servicies
{
    public class HandleContacts
    {
        private List<Contact> _contacts = [];
        private FileManager _fileManager = new FileManager(@"C:\projects\data", "contacts.json");

        public void AddContact()
        {
            Contact contact = new();

            Console.WriteLine("Enter your first name:");
            contact.FirstName = Console.ReadLine()!;
            Console.WriteLine("Enter your last name:");
            contact.LastName = Console.ReadLine()!;
            Console.WriteLine("Enter your email:");
            contact.Email = Console.ReadLine()!;
            Console.WriteLine("Enter your mobile number:");
            contact.PhoneNumber = Console.ReadLine()!;
            Console.WriteLine("Enter your address:");
            contact.Address = Console.ReadLine()!;
            Console.WriteLine("Enter your zip code:");
            contact.ZipCode = Console.ReadLine()!;
            Console.WriteLine("Enter your city:");
            contact.City = Console.ReadLine()!;

            _contacts.Add(contact);
            _fileManager.SaveToFile(_contacts);
        }

        public void ViewContacts()
        {
            _contacts = _fileManager.GetContacts();

            foreach (Contact contact in _contacts)
            {
                Console.WriteLine();
                Console.WriteLine($"{"Id:",-15} {contact.Id}");
                Console.WriteLine($"{"Name:", -15} {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"{"Email:",-15} {contact.Email}");
                Console.WriteLine($"{"Phone number:",-15} {contact.PhoneNumber}");
                Console.WriteLine($"{"Address:",-15} {contact.Address}, {contact.ZipCode} {contact.City}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
