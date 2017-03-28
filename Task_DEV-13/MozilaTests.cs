using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace task_DEV_13
{
    [TestClass]
    public class MozilaTests : BrowserTests
    {
        TestsMethods testMethods = new TestsMethods(url);

        [TestMethod]
        public void Mozila_ValidLoginValidPassword_Messages()
        {
            string actual= testMethods.TestAuthorizationWithMailPageNext(new FirefoxDriver(), validLogin, validPassword);
            string expected = "Входящие";
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
            string expected = "Авторизация";
            string actual = testMethods.TestAuthorizationWithAuthorizationPageNext(new FirefoxDriver(), "qwerty", validPassword, expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mozila_ValidLoginInvalidPassword_Authorization()
        {
            string expected = "Авторизация";
            string actual = testMethods.TestAuthorizationWithAuthorizationPageNext(new FirefoxDriver(), validLogin, "qwerty", expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void Mozila_EmptyLoginPassword_Authorization()
        {
            string expected = "Авторизация";
            string actual = testMethods.TestAuthorizationWithAuthorizationPageNext(new FirefoxDriver(), "", "", expected);
            Assert.AreEqual(expected, actual);
        }
    }
}
