using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace task_DEV_13
{
    class AuthorizationPageAfterInvalidLoginPassword
    {
        private IWebDriver webDriver;

        public AuthorizationPageAfterInvalidLoginPassword(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public string GetAuthorizationPageTitle(string authorizationTitle)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(15));
            wait.Until(ExpectedConditions.TitleContains(authorizationTitle));
            return webDriver.Title;
        }
    }
}
