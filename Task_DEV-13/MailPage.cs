using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace task_DEV_13
{
    class MailPage
    {
        private IWebDriver webDriver;
        private string inboxXpath = @"//span[text()='Входящие']";

        public MailPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;   
        }

        public IWebElement GetInboxElement()
        {
            WebDriverWait wait = new WebDriverWait(webDriver,TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.TitleContains("Входящие - Почта Mail.Ru"));
            return webDriver.FindElement(By.XPath(inboxXpath));
        }

    }
}
