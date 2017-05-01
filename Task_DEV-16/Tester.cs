using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using System.Diagnostics;

namespace FrameWork
{
    public class Tester
    {
        private Page page;
        private string readingPathFile;
        private ICommand command;
        private CommandCreator commandForTests;
        private IWebDriver driver = new ChromeDriver();

        public Tester(string readingPathFile, CommandCreator commandForTests)
        {
            this.readingPathFile = readingPathFile;
            this.commandForTests = commandForTests;
        }

        public void ReadCommand()
        {
            using (StreamReader streamReader = new StreamReader(readingPathFile))
            {
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    command = commandForTests.CreateCommand(line, this);
                    command.Execute();
                }
            }
        }

        public void Open(string url,double timeout)
        {
            Stopwatch testTime = new Stopwatch();
            testTime.Start();
            page = new Page(driver, url);
            page.GoUrl();
            testTime.Stop();
            Console.WriteLine(testTime.Elapsed);
        }

        public void CheckLinkByHref()
        {
 
        }

        public void CheckLinkPresentByName()
        {

        }

        public void CheckPageContains(string content)
        {
            Console.WriteLine(page.IsContains(content));
        }

        public void CheckPageTitle(string title)
        {
            Console.WriteLine("{0} ---- {1}", page.GetPageTitle(), title);
        }
    }
}
