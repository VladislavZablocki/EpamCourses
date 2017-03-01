using System;

namespace task_DEV_6
{
    /// <summary>
    /// convert input format to hour
    /// </summary>
    class Hour : GetDate
    {
        private DateTime dateTime;

        public Hour(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }
        public string GetInFormat(string format)
        {
            string outputHour = string.Empty;
            int hour = dateTime.Hour;
            if (format.Contains("H"))
            {
                if (format.Length == 1)
                {
                    outputHour = hour.ToString();
                }
                if (format.Length == 2)
                {
                    outputHour = hour.ToString();
                    if (hour < 10)
                    {
                        outputHour = string.Concat("0", hour.ToString());
                    }
                }
            }
            else
            {
                if (hour > 12)
                {
                    hour -= 12; 
                }
                if (format.Length == 1)
                {
                    outputHour = hour.ToString();
                }
                if (format.Length == 2)
                {
                    outputHour = hour.ToString();
                    if (hour < 10)
                    {
                        outputHour = string.Concat("0", hour.ToString());
                    }
                }
            }
            return outputHour;
        }
    }
}
