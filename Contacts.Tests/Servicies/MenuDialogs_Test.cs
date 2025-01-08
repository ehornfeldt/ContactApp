using System;
using System.IO;
using Contacts.Servicies;

namespace Contacts.Tests.Servicies
{
    public class MenuDialogs_Test
    {
        [Fact]
        public void TestMenuDialogOption1()
        {
            /* Detta är genererat av Chat GPT
             * Denna kod skapar en sträng '1' som sätter in värdet i 
             * konsollen, istället för att använda ReadLine. Den skapar
             * sedan en varabeln menuDialogs som kan använda sig av klassens
             * MenuDialogs metoder. MainMenu metoden returnerar en sträng som sedan
             * jämförs med userInput. Är de lika går testet igenom. */
            
            //arrange
            string userInput = "1";
            Console.SetIn(new StringReader(userInput));
            var menuDialogs = new MenuDialogs(); 

            //act
            string result = menuDialogs.MainMenu();

            //assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void TestMenuDialogOption2()
        {
            //arrange
            string userInput = "2";
            Console.SetIn(new StringReader(userInput));
            var menuDialogs = new MenuDialogs();

            //act
            string result = menuDialogs.MainMenu();

            //assert
            Assert.Equal("2", result);
        }

        [Fact]
        public void TestMenuDialogOptionQuit()
        {
            //arrange
            string userInput = "quit";
            Console.SetIn(new StringReader(userInput));
            var menuDialogs = new MenuDialogs();

            //act
            string result = menuDialogs.MainMenu();

            //assert
            Assert.Equal("quit", result);
        }

        [Fact]
        public void TestMenuDialogInvalidOptionsBeforeValidOption()
        {
            //arrange
            string userInput = "5\nhello\n1";
            Console.SetIn(new StringReader(userInput));
            var menuDialogs = new MenuDialogs();

            //act
            string result = menuDialogs.MainMenu();
            

            //assert
            Assert.Equal("1", result);
        }
    }
}
