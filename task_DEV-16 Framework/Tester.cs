using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using System.Diagnostics;

namespace FrameWork
{
    public class Tester
    {
        private string OutputPathFile = @"E:\c#\FrameWork\statistics.txt";
        private Page page;
        private string readingPathFile;
        private ICommand command;
        private CommandCreator commandForTests;
        private string lastCommand;
        private IWebDriver driver = new ChromeDriver();
        private Logger logger = new Logger();

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
                    lastCommand = line;
                    command = commandForTests.CreateCommand(line, this);
                    command.Execute();
                }
                logger.WriteStatistics(OutputPathFile);
            }
        }

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

        public void CheckLinkByHref()
        {
            Stopwatch testTime = new Stopwatch();
            testTime.Start();
            testTime.Stop();
        }

        public void CheckLinkPresentByName()
        {
            Stopwatch testTime = new Stopwatch();
            testTime.Start();
            testTime.Stop();
        }

        public void CheckPageContains(string content)
        {
            Stopwatch testTime = new Stopwatch();
            testTime.Start();
            bool isContains = page.IsContains(content);
            testTime.Stop();
            ResultString resultString = new ResultString(isContains, lastCommand, testTime.Elapsed);
            logger.addTestResult(resultString);
        }

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
