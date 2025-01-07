using Contacts.Models;
using Contacts.Servicies;

Console.WriteLine("Welcome to ContactApp");
Console.WriteLine("Choose your option, cancel by enter 'quit'");

MenuDialogs menu = new();
HandleContacts handleContacts = new();

//"contacts.json", @"C:\projects"

while (true)
{
    var option = menu.MainMenu();
    if(option == "1")
    {

        handleContacts.ViewContacts();

    } else if(option == "2")
    {
        handleContacts.AddContact();
    
    } else
    {
        Console.WriteLine("Good bye!");
        break;
    }
}

Console.ReadKey();
