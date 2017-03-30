using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
namespace task_DEV_13
{
    class MailPage
    {
        private IWebDriver webDriver;

        [FindsBy(How = How.XPath, Using = @"//*[@id='b-nav_folders']/div/div[2]/a/span")]
        public IWebElement InboxElement { get; set; }

        public MailPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementExists(By.XPath(@"//*[@id='b-nav_folders']/div/div[1]")));
            PageFactory.InitElements(this.webDriver, this);
        }

        public void Close()
        {
            webDriver.Close();
        }
    }
}
