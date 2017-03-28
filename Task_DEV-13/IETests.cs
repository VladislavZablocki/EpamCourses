using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace task_DEV_13
{
    [TestClass]
    public class IETests : BrowserTests
    {
        
        TestsMethods testMethods = new TestsMethods(url);

        [TestMethod]
        public void IE_ValidLoginValidPassword_Messages()
        {
            string actual = testMethods.TestAuthorizationWithMailPageNext(new InternetExplorerDriver(), validLogin, validPassword);
            string expected = "Входящие";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void IE_InvalidLoginValidPassword_Exception()
        {
            testMethods.TestAuthorizationWithMailPageNext(new InternetExplorerDriver(), "qwerty", validPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void IE_ValidLoginInvalidPassword_Exception()
        {
            testMethods.TestAuthorizationWithMailPageNext(new InternetExplorerDriver(), validLogin, "qwerty");
        }

        [TestMethod]
        public void IE_InvalidLoginValidPassword_Authorization()
        {
            string expected = "Вход - Почта Mail.Ru";
            string actual = testMethods.TestAuthorizationWithAuthorizationPageNext(new InternetExplorerDriver(), "qwerty", validPassword, expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IE_ValidLoginInvalidPassword_Authorization()
        {
            string expected = "Вход - Почта Mail.Ru";
            string actual = testMethods.TestAuthorizationWithAuthorizationPageNext(new InternetExplorerDriver(), validLogin, "qwerty", expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void IE_EmptyLoginPassword_Exception()
        {
            testMethods.TestAuthorizationWithMailPageNext(new InternetExplorerDriver(), " ", " ");
        }
    }
}
