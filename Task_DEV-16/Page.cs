using System;
using OpenQA.Selenium;

namespace FrameWork
{
    class Page
    {
        private IWebDriver webDriver;
        private IWebElement webElement;
        private string url;

        public Page(IWebDriver webDriver,string url)
        {
            this.webDriver = webDriver;
            this.url = url;
            GoUrl();
        }

        public void GoUrl()
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public string GetPageTitle()
        {
            return webDriver.Title;
        }

        public bool IsContains(string content)
        {
            return webDriver.PageSource.Contains(content);
        }
    }
}
