using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace FinalProject
{
    /// <summary>
    /// Class of wp-admin page
    /// </summary>
    class LoginPage : Page
    {
        private const string LoginPageAddress = "wp-admin";
        private string errorMessageId = "login_error";
        private WebDriverWait wait;

        [FindsBy(How = How.Id, Using = "user_login")]
        public IWebElement UserLogin { get; set; }

        [FindsBy(How = How.Id, Using = "user_pass")]
        public IWebElement UserPassword { get; set; }

        [FindsBy(How = How.Id, Using = "wp-submit")]
        public IWebElement LoginButton { get; set; }

        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            GoUrl(string.Concat(Domain, LoginPageAddress));
            PageFactory.InitElements(this.driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void LoginAs(string login, string password)
        {
            UserLogin.SendKeys(login);
            UserPassword.SendKeys(password);
            LoginButton.Click();
        }

        public void Close()
        {
            driver.Close();
        }

        public bool IsValidUser()
        {
            DashboardPage page = new DashboardPage(driver);
            return page.IsOnPage();
        }

        public bool IsInvalidUser()
        {
            bool result = true;
            try
            {
                wait.Until(ExpectedConditions.ElementExists(By.Id(errorMessageId)));
            }
            catch (TimeoutException)
            {
                result = false;
            }
            return result;
        }
    }
}
