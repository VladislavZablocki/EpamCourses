using System;

namespace FrameWork
{
    /// <summary>
    /// Result string of test. Contains bool field is successful test, string of command and time of test
    /// </summary>
    class ResultString
    {
        public bool IsSuccessful { get; set; }
        public string CommandString { get; set; }
        public TimeSpan TestTime { get; set; }

        public ResultString(bool isSuccessful,string commandString, TimeSpan testTime)
        {
            this.IsSuccessful = isSuccessful;
            this.CommandString = commandString;
            this.TestTime = testTime;
        }
    }
}
