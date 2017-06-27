using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace FinalProject
{
    /// <summary>
    /// Class of dashboard page wordpress
    /// </summary>
    class DashboardPage : Page
    {
        public IWebElement Title { get; set; }

        private WebDriverWait wait;

        public DashboardPage(IWebDriver driver)
            : base(driver)
        {
            PageFactory.InitElements(this.driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public bool IsOnPage()
        {
            bool result = true;
            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(
                    By.XPath(@"//*[@id='welcome-panel']/div/h2")));
            }
            catch (TimeoutException)
            {
                result = false;
            }
            return result;
        }
    }
}
