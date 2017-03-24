using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace task_DEV_13
{
    [TestClass]
    public class IETests
    {
        private string validLogin = "tat-dev13";
        private string validPassword = "23.03.2017";
        TestsMethods testMethods = new TestsMethods(@"https://mail.ru/");

        [TestMethod]
        public void IE_ValidLoginValidPassword_Messages()
        {
            string expected = testMethods.TestAuthorizationWithMailPageNext(new InternetExplorerDriver(), validLogin, validPassword);
            string actual = "Входящие";
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
        public void IE_InvalidLoginValidPassword_Exception()
        {
            testMethods.TestAuthorizationWithMailPageNext(new InternetExplorerDriver(), validLogin, "qwerty");
        }

        [TestMethod]
        public void IE_InvalidLoginValidPassword_Authorization()
        {
            string actual = "Вход - Почта Mail.Ru";
            string expected = testMethods.TestAuthorizationWithAuthorizationPageNext(new InternetExplorerDriver(), "qwerty", validPassword, actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IE_ValidLoginInvalidPassword_Authorization()
        {
            string actual = "Вход - Почта Mail.Ru";
            string expected = testMethods.TestAuthorizationWithAuthorizationPageNext(new InternetExplorerDriver(), validLogin, "qwerty", actual);
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
