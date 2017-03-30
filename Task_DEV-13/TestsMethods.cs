using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

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

        public string GoToMailPage(IWebDriver webDriver,string login,string password)
        {
            StartPage startPage = new StartPage(webDriver,path);
            startPage.SetLogin(login);
            startPage.SetPassword(password);
            MailPage mailPage = startPage.ClickButton();
            string mailPageString = mailPage.InboxElement.Text;
            mailPage.Close();
            return mailPageString;
        }
    }
}
