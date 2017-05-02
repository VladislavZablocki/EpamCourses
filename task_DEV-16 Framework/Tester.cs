using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Diagnostics;

namespace FrameWork
{
    /// <summary>
    /// Class with tests methods
    /// </summary>
    public class Tester
    {
        private string outputPathFile;
        private Page page;
        private string readingPathFile;
        private ICommand command;
        private CommandCreator commandForTests;
        private string lastCommand;
        private IWebDriver driver = new ChromeDriver();
        private Logger logger = new Logger();

        public Tester(string readingPathFile,string outputPathFile, CommandCreator commandForTests)
        {
            this.outputPathFile = outputPathFile;
            this.readingPathFile = readingPathFile;
            this.commandForTests = commandForTests;
        }

        /// <summary>
        /// Method wich read string with command from file and execute this command
        /// </summary>
        public void ReadCommand()
        {
            using (StreamReader streamReader = new StreamReader(readingPathFile))
            {
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    lastCommand = line;
                    command = commandForTests.CreateCommand(line, this);
                    if (command == null)
                    {
                        ResultString resultString = new ResultString(false, lastCommand, TimeSpan.Zero);
                    }
                    else
                    {
                        command.Execute();
                    }
                }
                logger.WriteStatistics(outputPathFile);
            }
        }

        /// <summary>
        /// Open page
        /// </summary>
        /// <param name="url">url page</param>
        /// <param name="timeout">timeout for opening page</param>
        public void Open(string url,double timeout)
        {
            Stopwatch testTime = new Stopwatch();
            testTime.Start();
            page = new Page(driver, url);
            page.GoUrl();
            testTime.Stop();
            ResultString resultString = new ResultString(timeout >= testTime.Elapsed.Seconds, lastCommand, testTime.Elapsed);
            logger.addTestResult(resultString);
        }

        /// <summary>
        /// Check link of page by href
        /// </summary>
        /// <param name="href">href</param>
        public void CheckLinkByHref(string href)
        {
            Stopwatch testTime = new Stopwatch();
            testTime.Start();
            bool isContains = page.IsLinkExistByHref(href);
            testTime.Stop();
            ResultString resultString = new ResultString(isContains, lastCommand, testTime.Elapsed);
            logger.addTestResult(resultString);
        }

        /// <summary>
        /// check link by name of this link
        /// </summary>
        /// <param name="name"></param>
        public void CheckLinkPresentByName(string name)
        {
            Stopwatch testTime = new Stopwatch();
            testTime.Start();
            bool isContains = page.IsLinkExistByName(name);
            testTime.Stop();
            ResultString resultString = new ResultString(isContains, lastCommand, testTime.Elapsed);
            logger.addTestResult(resultString);
        }

        /// <summary>
        /// check content of page
        /// </summary>
        /// <param name="content">content</param>
        public void CheckPageContains(string content)
        {
            Stopwatch testTime = new Stopwatch();
            testTime.Start();
            bool isContains = page.IsContains(content);
            testTime.Stop();
            ResultString resultString = new ResultString(isContains, lastCommand, testTime.Elapsed);
            logger.addTestResult(resultString);
        }

        /// <summary>
        /// check title of page
        /// </summary>
        /// <param name="title">title</param>
        public void CheckPageTitle(string title)
        {
            Stopwatch testTime = new Stopwatch();
            testTime.Start();
            bool isCorrect = page.GetPageTitle().Equals(title);
            testTime.Stop();
            ResultString resultString = new ResultString(isCorrect, lastCommand, testTime.Elapsed);
            logger.addTestResult(resultString);
            
        }
    }
}
