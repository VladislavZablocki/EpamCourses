using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace task_DEV_13
{
    [TestClass]
    public class MozilaTests
    {
        TestsMethods testMethods = new TestsMethods(@"https://mail.ru/");
        private string validLogin = "tat-dev13";
        private string validPassword = "23.03.2017";

        [TestMethod]
        public void Mozila_ValidLoginValidPassword_Messages()
        {
            string expected = testMethods.TestAuthorizationWithMailPageNext(new FirefoxDriver(), validLogin, validPassword);
            string actual = "Входящие";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void Mozila_InvalidLoginValidPassword_Exception()
        {
            testMethods.TestAuthorizationWithMailPageNext(new FirefoxDriver(), "1", validPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void Mozila_ValidLoginInvalidPassword_Exception()
        {
            testMethods.TestAuthorizationWithMailPageNext(new FirefoxDriver(), validLogin, "qwerty");
        }

        [TestMethod]
        public void Mozila_InvalidLoginValidPassword_Authorization()
        {
            string actual = "Авторизация";
            string expected = testMethods.TestAuthorizationWithAuthorizationPageNext(new FirefoxDriver(), "qwerty", validPassword, actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mozila_ValidLoginInvalidPassword_Authorization()
        {
            string actual = "Авторизация";
            string expected = testMethods.TestAuthorizationWithAuthorizationPageNext(new FirefoxDriver(), validLogin, "qwerty", actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void Mozila_EmptyLoginPassword_Authorization()
        {
            string actual = "Авторизация";
            string expected = testMethods.TestAuthorizationWithAuthorizationPageNext(new FirefoxDriver(), "", "", actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
