using System;

namespace task_DEV_6
{
    /// <summary>
    /// convert input format to seconds
    /// </summary>
    public class Seconds : IGetDateOrTime
    {
        private DateTime dateTime;

        public Seconds(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string GetInFormat(string format)
        {
            string outputSeconds = dateTime.Second.ToString();
            if (format.Length == 2)
            {
                if (outputSeconds.Length == 1)
                {
                    outputSeconds = string.Concat("0", outputSeconds);
                }
            }
            return outputSeconds;
        }
    }
}
