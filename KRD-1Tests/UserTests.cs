using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRD_1;
using NUnit.Framework;

namespace KRD_1Tests
{
    [TestFixture]
    class UserTests
    {
        private ICheckCorrectness _sut;
        [SetUp]
        public void SetUp()
        {
            _sut = new User();
        }

        [Test]
        [TestCase("303003")]
        [TestCase(";dld;")]
        [TestCase("123aao")]
        public void NameSet_With_Wrong_Values(String text)
        {
            // Arrange
            var user = new User();
            // Act
            user.Name = text;
            // Assert
            Assert.AreNotEqual(text, user.Name);
        }

        [Test]
        [TestCase("a1233a")]
        [TestCase("s=ssa1")]
        [TestCase("A;leksan][dra")]
        public void ContainsOnlyLetters_Checking_If_Wrong_String_Contains_Only_Letters(String text)
        {
            // Arrange
            // Act
            var actualResult = _sut.ContainsOnlyLetters(text);
            // Assert
            Assert.IsFalse(actualResult);

        }

        [Test]
        [TestCase("aoaaoaoa")]
        [TestCase("s")]
        [TestCase("Aleksandra")]
        public void ContainsOnlyLetters_Checking_If_String_Contains_Only_Letters(String text)
        {
            // Arrange

            // Act
            var actualResult = _sut.ContainsOnlyLetters(text);
            // Assert
            Assert.IsTrue(actualResult);
        }


        [Test]
        [TestCase("Maja")]
        [TestCase("WesolyGrzybek")]
        [TestCase("polibuda")]
        public void ContainsNumber_Checking_Correctness_With_Correct_Data_Should_Return_True(String text)
        {
            // Arrange

            // Act 
            var actualResult = _sut.ContainsNumber(text);

            // Assert
            Assert.False(actualResult);
        }

        [Test]
        [TestCase("ola123")]
        [TestCase("1234")]
        [TestCase(";sl1s")]
        public void ContainsNumber_Checking_Correctness_With_Invaild_Data_Should_Return_False(String text)
        {
            // Arrange
            var user = new User();

            // Act 
            var actualResult = _sut.ContainsNumber(text);

            // Assert
            Assert.IsTrue(actualResult);

        }

        [Test]
        [TestCase("Ola", "")]
        [TestCase("Zbigniew", "")]
        [TestCase("Eustachy", "")]
        public void Setting_Name_Should_Set_Name(String settedName, String gettedName)
        {
            // Arrange
            var user = new User();

            // Act
            user.Name = settedName;
            
            // Assert
            Assert.AreNotEqual(user.Name.Length, String.Empty.Length);
            Assert.IsNotEmpty(user.Name);
        }
    }
}
