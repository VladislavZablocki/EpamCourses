using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
namespace task_DEV_13
{
    class StartPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.Id, Using = "mailbox__login")]
        public IWebElement Login { get; set; }

        [FindsBy(How = How.Id, Using = "mailbox__password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "mailbox__auth__button")]
        public IWebElement Button { get; set; }

        public StartPage(IWebDriver webDriver,string url)
        {
            this.webDriver = webDriver;
            goUrl(url);
            PageFactory.InitElements(this.webDriver, this);
        }

        public void goUrl(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public void SetLogin(string login)
        {
            Login.Clear();
            Login.SendKeys(login);
        }

        public void SetPassword(string password)
        {
            Password.Clear();
            this.Password.SendKeys(password);
        }

        public MailPage ClickButton()
        {
            Button.Click();
            return new MailPage(webDriver);
        }
    }
}
