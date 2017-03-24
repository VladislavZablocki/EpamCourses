using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace task_DEV_13
{
    [TestClass]
    public class ChromeTests
    {
        private string validLogin = "tat-dev13";
        private string validPassword = "23.03.2017";
        TestsMethods testMethods = new TestsMethods(@"https://mail.ru/");

        [TestMethod]
        public void Chrome_ValidLoginValidPasword_Messages()
        {
            string expected = testMethods.TestAuthorizationWithMailPageNext(new ChromeDriver(), validLogin, validPassword);
            string actual = "Входящие";
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
            string actual = "Авторизация";
            string expected = testMethods.TestAuthorizationWithAuthorizationPageNext(new ChromeDriver(), "qwerty", validLogin, actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Chrome_ValidLoginInvalidPassword_Authorization()
        {
            string actual = "Авторизация";
            string expected = testMethods.TestAuthorizationWithAuthorizationPageNext(new ChromeDriver(), validLogin, "qwerty", actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Chrome_EmptyLoginPassword_Authorization()
        {
            string actual = "Авторизация";
            string expected = testMethods.TestAuthorizationWithAuthorizationPageNext(new ChromeDriver(), "", "", actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
