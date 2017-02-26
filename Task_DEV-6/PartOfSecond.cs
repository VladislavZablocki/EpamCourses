using System;

namespace task_DEV_6
{
    /// <summary>
    /// convert input format to part of seconds
    /// </summary>
    class PartOfSecond : GetDate
    {
        private DateTime dateTime;

        public PartOfSecond(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string GetInFormat(string format)
        {
            string outputSplitOfSeconds = dateTime.Millisecond.ToString();
            while (outputSplitOfSeconds.Length < 3)
            {
                outputSplitOfSeconds = string.Concat("0", outputSplitOfSeconds);
            }
            while (outputSplitOfSeconds.Length < format.Length)
            {
                outputSplitOfSeconds = string.Concat(outputSplitOfSeconds, "0");
            }
            if (format.Contains("f"))
            {
                outputSplitOfSeconds = outputSplitOfSeconds.Substring(0, format.Length);
            }
            if (format.Contains("F"))
            {
                outputSplitOfSeconds = outputSplitOfSeconds.Substring(0, format.Length);

                if (int.Parse(outputSplitOfSeconds) == 0)
                {
                    outputSplitOfSeconds = "0";
                }
            }
            return outputSplitOfSeconds;
        }
    }
}
