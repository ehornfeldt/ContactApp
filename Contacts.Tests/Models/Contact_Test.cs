using Contacts.Models;
using Contacts.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Tests.Models
{
    public class Contact_Test
    {
        [Fact]
        public void IdIsUniq()
        {
            //arrange
            Contact contact1 = new();
            Contact contact2 = new();

            //act
            string id1 = contact1.Id;
            string id2 = contact2.Id;

            //assert
            Assert.NotEqual(id1, id2);

        }

        [Fact]
        public void IdIsOfTypeGuid()
        {
            //arrange
            Contact contact = new();

            //act
            string id = contact.Id;

            //assert
            Assert.True(Guid.TryParse(id, out _));

        }

        [Fact]
        public void CanCreateFirstName()
        {
            //arrange
            Contact contact = new();
            string name = "John";

            //act
            contact.FirstName = name;

            //assert
            Assert.Equal(contact.FirstName, name);

        }

        [Fact]
        public void CanCreateLastName()
        {
            //arrange
            Contact contact = new();
            string lastName = "Doe";

            //act
            contact.LastName = lastName;

            //assert
            Assert.Equal(contact.LastName, lastName);

        }

        [Fact]
        public void CanCreateEmail()
        {
            //arrange
            Contact contact = new();
            string email = "mail@mail.com";

            //act
            contact.Email = email;

            //assert
            Assert.Equal(contact.Email, email);

        }

        [Fact]
        public void CanCreatePhoneNumber()
        {
            //arrange
            Contact contact = new();
            string number = "070-12 345 678";

            //act
            contact.PhoneNumber = number;

            //assert
            Assert.Equal(contact.PhoneNumber, number);

        }

        [Fact]
        public void CanCreateAddress()
        {
            //arrange
            Contact contact = new();
            string address = "Great road 100";
            string zipCode = "100 10";
            string city = "Awesome town";

            //act
            contact.Address = address;
            contact.ZipCode = zipCode;
            contact.City = city;

            //assert
            Assert.Equal(contact.Address, address);
            Assert.Equal(contact.ZipCode, zipCode);
            Assert.Equal(contact.City, city);
        }
    }
}
