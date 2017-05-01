using System;

namespace FrameWork
{
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
