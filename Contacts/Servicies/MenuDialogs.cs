namespace Contacts.Servicies
{
    public class MenuDialogs
    {
        public string MainMenu()
        {
            while (true)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"{"1.",-5} View contacts");
                Console.WriteLine($"{"2.",-5} Add new contact");
                Console.WriteLine("Choose an option");
                var option = Console.ReadLine()!;
                if (CheckOption(option))
                {
                    return option;
                } else if(option == "quit") {
                    return "quit";
                }
                Console.WriteLine("Choose a number between 1 or 2");
            }
        }

        private bool CheckOption(string option)
        {
            if (option == "1" || option == "2")
            {
                return true;
            }
            return false;
        }
    }
}
