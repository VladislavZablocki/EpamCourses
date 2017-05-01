using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FrameWork
{
    class Logger
    {
        private List<ResultString> testResults = new List<ResultString>();

        public void addTestResult(ResultString result)
        {
            testResults.Add(result);
        }

        public void WriteStatistics(string path)
        {
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                TimeSpan totalTime = TimeSpan.Zero;
                TimeSpan averageTime = TimeSpan.Zero;
                foreach (var item in testResults)
                {
                    char isSuccessful = item.IsSuccessful ? '+' : '!';
                    streamWriter.WriteLine(string.Concat(isSuccessful, " [ ", item.CommandString.ToString(), " ] ", item.TestTime.ToString(@"ss\.fff")));
                    totalTime += item.TestTime;
                }
                averageTime = new TimeSpan(totalTime.Ticks / testResults.Count);
                streamWriter.WriteLine(string.Concat("Total tests : ", testResults.Count));
                streamWriter.WriteLine(string.Concat("Passed/Failed :",testResults.Where(tests => tests.IsSuccessful==true).Count(),"/",
                    testResults.Where(tests => tests.IsSuccessful==false).Count()));
                streamWriter.WriteLine(string.Concat("Total time : ", totalTime.ToString(@"ss\.fff")));
                streamWriter.WriteLine(string.Concat("Average time : ", averageTime.ToString(@"ss\.fff")));
            }
        }
    }
}
