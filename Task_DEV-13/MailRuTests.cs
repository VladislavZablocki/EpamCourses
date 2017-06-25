using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Data.OleDb;

namespace task_DEV_13
{
    [TestClass]
    public class MailRuTests
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        const string Url = @"https://mail.ru/";
        const string Library = "System.Data.OleDb";
        const string ValidLoginPasswordTable = "ValidLoginPassword";
        const string InvalidLoginPasswordTable = "InvalidLoginPassword";
        const string Provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"F:\\LoginPassword.mdb\"";
        const string SentMessage = "Отправленные";
        TestsMethods testMethods = new TestsMethods(Url);
        
        [TestMethod]
        [DataSource(Library, Provider, ValidLoginPasswordTable, DataAccessMethod.Sequential)]
        public void Chrome_ValidLoginPassword_MailPage()
        {
            string expected = SentMessage;
            string login = Convert.ToString(testContextInstance.DataRow[1]);
            string password = Convert.ToString(testContextInstance.DataRow[2]);
            string actual = testMethods.GoToMailPage(new ChromeDriver(), login, password);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataSource(Library, Provider, ValidLoginPasswordTable, DataAccessMethod.Sequential)]
        public void Edge_ValidLoginPassword_MailPage()
        {
            string expected = SentMessage;
            string login = Convert.ToString(testContextInstance.DataRow[1]);
            string password = Convert.ToString(testContextInstance.DataRow[2]);
            string actual = testMethods.GoToMailPage(new EdgeDriver(), login, password);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataSource(Library, Provider, ValidLoginPasswordTable, DataAccessMethod.Sequential)]
        public void FireFox_ValidLoginPassword_MailPage()
        {
            string expected = SentMessage;
            string login = Convert.ToString(testContextInstance.DataRow[1]);
            string password = Convert.ToString(testContextInstance.DataRow[2]);
            string actual = testMethods.GoToMailPage(new FirefoxDriver(), login, password);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataSource(Library, Provider, InvalidLoginPasswordTable, DataAccessMethod.Sequential)]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void Chrome_InvalidLoginPassword_Exception()
        {
            string expected = SentMessage;
            string login = Convert.ToString(testContextInstance.DataRow[1]);
            string password = Convert.ToString(testContextInstance.DataRow[2]);
            string actual = testMethods.GoToMailPage(new ChromeDriver(), login, password);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataSource(Library, Provider, InvalidLoginPasswordTable, DataAccessMethod.Sequential)]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void Edge_InvalidLoginPassword_Exception()
        {
            string expected = SentMessage;
            string login = Convert.ToString(testContextInstance.DataRow[1]);
            string password = Convert.ToString(testContextInstance.DataRow[2]);
            string actual = testMethods.GoToMailPage(new EdgeDriver(), login, password);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataSource(Library, Provider, InvalidLoginPasswordTable, DataAccessMethod.Sequential)]
        [ExpectedException(typeof(WebDriverTimeoutException))]
        public void FireFox_InvalidLoginPassword_Exception()
        {
            string expected = SentMessage;
            string login = Convert.ToString(testContextInstance.DataRow[1]);
            string password = Convert.ToString(testContextInstance.DataRow[2]);
            string actual = testMethods.GoToMailPage(new FirefoxDriver(), login, password);
            Assert.AreEqual(actual, expected);
        }
    }
}
