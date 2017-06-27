using OpenQA.Selenium;

namespace FinalProject
{
    public class Page
    {
        protected IWebDriver driver; 
        protected const string Domain = @"http://localhost:8080/";

        protected Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void GoUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
