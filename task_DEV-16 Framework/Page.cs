using System;
using OpenQA.Selenium;

namespace FrameWork
{
    /// <summary>
    /// Class of page
    /// </summary>
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

        /// <summary>
        /// Check if the page contains the text
        /// </summary>
        /// <param name="content">text</param>
        /// <returns>true or false</returns>
        public bool IsContains(string content)
        {
            return webDriver.PageSource.Contains(content);
        }

        /// <summary>
        /// Check if the page contains link by name of link
        /// </summary>
        /// <param name="text">name of link</param>
        /// <returns>true or false</returns>
        public bool IsLinkExistByName(string text)
        {
            bool isExist = true;
            try
            {
                string xpath = string.Concat(@".//*[text()='", text, @"']/@href");
                IWebElement link = webDriver.FindElement(By.XPath(xpath));
            }
            catch (Exception) 
            {
                isExist = false;
            }
            return isExist;
        }

        /// <summary>
        /// Check if the page contains link by href of link
        /// </summary>
        /// <param name="href">href</param>
        /// <returns>true or false</returns>
        public bool IsLinkExistByHref(string href)
        {
            bool isExist = true;
            try
            {
                string xpath = string.Concat(@".//*[contains(@href, '", href, @"')]");
                IWebElement link = webDriver.FindElement(By.XPath(xpath));
            }
            catch (Exception)
            {
                isExist = false;
            }
            return isExist;
        }
    }
}
