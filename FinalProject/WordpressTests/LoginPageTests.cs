using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace FinalProject
{
    [TestClass]
    public class LoginPageTests
    {
        EdgeDriver driver = new EdgeDriver();
        FileReader reader = new FileReader();
        [TestMethod]
        public void LoginPage_ValidLogin()
        {

            LoginPage page = new LoginPage(driver);
            List<string[]> data = reader.GetDataFrom("validLogin.txt");
            foreach (var item in data)
            {
                page.LoginAs(item[0], item[1]);
                Assert.AreEqual(true, page.IsValidUser());
            }
            page.Close();
        }

        [TestMethod]
        public void LoginPage_InvalidLogin()
        {
            LoginPage page = new LoginPage(driver);
            List<string[]> data = reader.GetDataFrom("invalidLogin.txt");
            foreach (var item in data)
            {
                page.LoginAs(item[0], item[1]);
                Assert.AreEqual(true, page.IsInvalidUser());
            }
            page.Close();
        }
    }
}
