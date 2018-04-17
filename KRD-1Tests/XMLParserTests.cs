using KRD_1;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace KRD_1Tests
{
    [TestFixture]
    class XMLParserTests
    {
        private List<Package> allPackages;
        //XmlDocument document = null;

        [SetUp]
        public void SetUp()
        {
            allPackages = null;
        }

        [Test]
        public void SerializeListOfUsers()
        {
            // Arrange
            var parser = new XMLParser();
            parser.ListOfUsersFileName = "test.xml";
            var listOfUsers = new List<User>()
            { 
                new User()
                {
                    Name = "Jan",
                    Surname = "Kowalski",
                    Street = "Kwiatowa",
                    Gender = 'M',
                    Country = "Poland"
                },
                new User()
                {
                    Name = "Angelina",
                    Surname = "Jolie",
                    Street = "Pilsudskiego",
                    Gender = 'K',
                    Country = "USA"
                },
                new User()
                {
                    Name = "Jan",
                    Surname = "Kowalski",
                    Street = "Kwiatowa",
                    Gender = 'M',
                    Country = "Poland"
                }
            };

            // Act
            parser.SerializeListOfUsers(listOfUsers);
            // Assert
            // Spr, czy się zapisały do pliku 
            // bez białych znaków, czy się równają -> tab tut
        }
        
        [Test]
        [TestCase(1, "w systemie", "6 PM")]
        public void LoadPackages(int id, String status, String hour)
        {
            // To do poprawy
            // Arrange
            var parser = new XMLParser();
            allPackages = null;
            // usuwanie białych znaków zrób <- tut
            String xml = @"<ArrayOfPackage>
                             < Package >
                                < Id >id</ Id >
                                < Status >w systemie</ Status >
                                < Hour >6 PM</ Hour >
                             </ Package >
                          </ ArrayOfPackage > ";
            // Act
            allPackages = parser.LoadPackages();
            // Assert
            foreach(Package p in allPackages)
            {
                Assert.AreEqual(id, p.Id);
                Assert.AreEqual(status, p.Status);
                Assert.AreEqual(hour, p.Hour);
            }
        }

        [Test]
        [TestCase(1, "w systemie")]
        [TestCase(2, "w systemie")]
        [TestCase(3, "w systemie")]
        public void ChangeStatusOfPackage(int index, String newStatus)
        {
            // najpierw ustaw jakies <--- 
            // Arrange
            var parser = new XMLParser();
            // Act
            ChangeStatusOfPackage(index, newStatus);
            // Assert
            // Get node with this index and check
        }

        [Test]
        public void DeserializeListOfUsers()
        {
            // Arrange
            List<User> listOfUsers = new List<User>();
            var parser = new XMLParser();
            // Act
            listOfUsers = parser.DeserializeListOfUsers(listOfUsers);
            // Assert
            Assert.NotNull(listOfUsers);
        }

        [Test]
        [TestCase("admin", "1234")]
        [TestCase("user123", "123")]
        [TestCase("student", "student")]
        public void IsValidLogin(string username, string password)
        {
            // Arrange
            var parser = new XMLParser();
            // Act
            bool result = parser.IsValidLogin(username, password);
            // Assert
            Assert.True(result);
        }
    }
}
