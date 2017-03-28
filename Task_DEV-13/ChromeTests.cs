using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace task_DEV_13
{
    [TestClass]
    public class ChromeTests : BrowserTests
    {
        TestsMethods testMethods = new TestsMethods(url);

        [TestMethod]
        public void Chrome_ValidLoginValidPasword_Messages()
        {
            string actual  = testMethods.TestAuthorizationWithMailPageNext(new ChromeDriver(), validLogin, validPassword);
            string expected= "Входящие";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void Chrome_InvalidLoginValidPassword_Exception()
        {
            testMethods.TestAuthorizationWithMailPageNext(new ChromeDriver(), "qwerty", validPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void Chrome_ValidLoginInvalidPassword_Exception()
        {
            testMethods.TestAuthorizationWithMailPageNext(new ChromeDriver(), validLogin, "qwerty");
        }

        [TestMethod]
        public void Chrome_InvalidLoginvalidPassword_Authorization()
        {
            string expected = "Авторизация";
            string actual = testMethods.TestAuthorizationWithAuthorizationPageNext(new ChromeDriver(), "qwerty", validLogin, expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Chrome_ValidLoginInvalidPassword_Authorization()
        {
            string expected = "Авторизация";
            string actual = testMethods.TestAuthorizationWithAuthorizationPageNext(new ChromeDriver(), validLogin, "qwerty", expected);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Chrome_EmptyLoginPassword_Authorization()
        {
            string expected = "Авторизация";
            string actual = testMethods.TestAuthorizationWithAuthorizationPageNext(new ChromeDriver(), "", "", expected);
            Assert.AreEqual(expected, actual);
        }
    }
}
