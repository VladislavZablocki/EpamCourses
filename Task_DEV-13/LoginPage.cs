using System;
using OpenQA.Selenium;

namespace task_DEV_13
{
    class LoginPage
    {
        private IWebDriver webDriver;
        private string loginId = "mailbox__login";
        private string passwordId = "mailbox__password";
        private string buttonId = "mailbox__auth__button";

        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public void goUrl(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public IWebElement GetLoginCell()
        {
            return webDriver.FindElement(By.Id(loginId));
        }

        public IWebElement GetPasswordCell()
        {
            return webDriver.FindElement(By.Id(passwordId));
        }

        public IWebElement GetButton()
        {
            return webDriver.FindElement(By.Id(buttonId));
        }

        public void SetStringInCell(IWebElement webElement, string inputString)
        {
            webElement.SendKeys(inputString);
        }

        public AuthorizationPageAfterInvalidLoginPassword ClickAuthorizationPage(IWebElement webElement)
        {
            webElement.Click();
            return new AuthorizationPageAfterInvalidLoginPassword(webDriver);
        }

        public MailPage ClickButtonMailPage(IWebElement webElement)
        {
            webElement.Click();
            return new MailPage(webDriver);
        }

        public void ClearCell(IWebElement webElement)
        {
            webElement.Clear();
        }

    }
}
