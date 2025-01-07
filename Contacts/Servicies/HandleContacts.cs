using Contacts.Models;
using System.Text.Json;

namespace Contacts.Servicies
{
    public class HandleContacts
    {
        private List<Contact> _contacts = [];

        public void AddContact()
        {
            Contact contact = new();
            Console.Clear();

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

            Console.WriteLine($"Ditt namn är: {contact.FirstName} {contact.LastName}");

            _contacts.Add(contact);

            //string fileName = "Contacts.json";
            //string jsonString = JsonSerializer.Serialize(contact);
            //File.WriteAllText(fileName, jsonString );
            //Console.WriteLine(File.ReadAllText(fileName));
        }

        public void ViewContacts()
        {
            Console.Clear();

            foreach (Contact contact in _contacts)
            {
                Console.WriteLine($"Id: {contact.Id}");
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"Phone number: {contact.PhoneNumber}");
                Console.WriteLine($"Address: {contact.Address} {contact.ZipCode} {contact.City}");
            }
            Console.ReadKey();
        }
    }
}
