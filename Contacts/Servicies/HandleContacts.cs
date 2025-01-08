using Contacts.Models;
using System.Text.Json;

namespace Contacts.Servicies
{
    public class HandleContacts
    {
        private List<Contact> _contacts = [];
        private ContactDialog _dialog = new();
        private FileManager _fileManager = new FileManager(@"C:\projects\data", "contacts.json");

        public void AddContact()
        {
            Contact contact = new();
            contact = _dialog.AddDialog(contact);
            _contacts.Add(contact);
            _fileManager.SaveToFile(_contacts);
        }

        public void ViewContacts()
        {
            _contacts = _fileManager.GetContacts();
            _dialog.ViewDialog(_contacts);
        }
    }
}
