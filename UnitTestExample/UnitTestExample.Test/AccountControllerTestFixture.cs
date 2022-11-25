using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [Test,
        TestCase("abcd1234", false),
        TestCase("irf@uni-corvinus", false),
        TestCase("irf.uni-corvinus.hu", false),
        TestCase("irf@uni-corvinus.hu", true)]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);


        }

        [Test,
        TestCase("Abcdefgh", false),
        TestCase("ABCDEFG7", false),
        TestCase("abcdefg7", false),
        TestCase("Abcdef7", false),
        TestCase("Abcdefg7", true)]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            var accountController = new AccountController();
            var actualResult = accountController.ValidatePassword(password);
            Assert.AreEqual(actualResult, expectedResult);
        }
        
    }
}
