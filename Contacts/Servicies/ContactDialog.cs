using Contacts.Models;

namespace Contacts.Servicies
{
    public class ContactDialog
    {
        public Contact AddDialog(Contact contact)
        {

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

            return contact;
        }
        public void ViewDialog(List<Contact> _contacts)
        {

            foreach (Contact contact in _contacts)
            {
                Console.WriteLine();
                Console.WriteLine($"{"Id:",-15} {contact.Id}");
                Console.WriteLine($"{"Name:",-15} {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"{"Email:",-15} {contact.Email}");
                Console.WriteLine($"{"Phone number:",-15} {contact.PhoneNumber}");
                Console.WriteLine($"{"Address:",-15} {contact.Address}, {contact.ZipCode} {contact.City}");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
