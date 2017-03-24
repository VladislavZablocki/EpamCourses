using OpenQA.Selenium;

namespace task_DEV_13
{
    /// <summary>
    /// Class which contains tests methods 
    /// </summary>
    class TestsMethods
    {
        private string path;

        public TestsMethods(string path)
        {
            this.path = path;
        }

        public string TestAuthorizationWithAuthorizationPageNext(IWebDriver webDriver, string login, string password, string authorizationTitle)
        {
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.goUrl(path);
            IWebElement loginElement = loginPage.GetLoginCell();
            IWebElement passwordElement = loginPage.GetPasswordCell();
            IWebElement buttonElement = loginPage.GetButton();
            loginPage.ClearCell(loginElement);
            loginPage.SetStringInCell(loginElement, login);
            loginPage.SetStringInCell(passwordElement, password);
            AuthorizationPageAfterInvalidLoginPassword authorizationPage = loginPage.ClickAuthorizationPage(buttonElement);
            string title = authorizationPage.GetAuthorizationPageTitle(authorizationTitle);
            webDriver.Quit();
            return title;
        }

        public string TestAuthorizationWithMailPageNext(IWebDriver webDriver, string login, string password)
        {
            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.goUrl(path);
            IWebElement loginElement = loginPage.GetLoginCell();
            IWebElement passwordElement = loginPage.GetPasswordCell();
            IWebElement buttonElement = loginPage.GetButton();
            loginPage.ClearCell(loginElement);
            loginPage.SetStringInCell(loginElement, login);
            loginPage.SetStringInCell(passwordElement, password);
            MailPage mailPage = loginPage.ClickButtonMailPage(buttonElement);
            IWebElement inboxElement = mailPage.GetInboxElement();
            string text = inboxElement.Text;
            webDriver.Quit();
            return text;
        }
    }
}
