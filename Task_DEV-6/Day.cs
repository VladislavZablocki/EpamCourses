using System;

namespace task_DEV_6
{
    /// <summary>
    /// convert input format to day
    /// </summary>
    class Day : GetDate
    {
        private DateTime dateTime;

        public Day(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string GetInFormat(string format)
        {
            string outputDay = string.Empty;
            if (format.Length == 1)
            {
                outputDay = dateTime.Day.ToString();
            }
            if (format.Length == 2)
            {
                if (dateTime.Day < 10)
                {
                    outputDay = string.Concat("0", dateTime.Day);
                }
                else
                {
                    outputDay = dateTime.Day.ToString();
                }
            }
            if (format.Length == 3)
            {
                outputDay = dateTime.DayOfWeek.ToString().Substring(0, 3);
            }
            if (format.Length == 4)
            {
                outputDay = dateTime.DayOfWeek.ToString();
            }
            return outputDay;
        }
    }
}
