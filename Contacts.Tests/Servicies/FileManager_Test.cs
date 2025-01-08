using Contacts.Models;
using Contacts.Servicies;

namespace Contacts.Tests.Servicies
{
    public class FileManager_Test
    {
        /*Ideer om vad som kan testas är från ChatGPT, men koden är omskriven*/
        private string _filePath = Path.Combine(@"C:\projects\data\test", "test.json");
        private List<Contact> _list = new List<Contact>
            {
                new Contact { FirstName = "John", LastName = "Doe", Email = "john.doe@mail.com", PhoneNumber = "070 - 123 45 67" },
                new Contact { FirstName = "Jane", LastName = "Doe", Email = "jane.doe@mail.com", PhoneNumber = "070 - 098 76 54" }
            };

        [Fact]
        public void SaveToFileTest()
        {
            //arrange
            var fileManager = new FileManager(@"C:\projects\data\test", "test.json");

            //act
            fileManager.SaveToFile(_list);

            //assert
            Assert.True(File.Exists(_filePath));
        }

        [Fact]
        public void GetContactsTest()
        {
            //arrange
            var fileManager = new FileManager(@"C:\projects\data\test", "test.json");
            fileManager.SaveToFile(_list);;

            //act
            var getContacts = fileManager.GetContacts();

            //assert
            Assert.IsType<List<Contact>>(getContacts);
        }
    }
}
