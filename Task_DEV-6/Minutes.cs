using System;

namespace task_DEV_6
{
    /// <summary>
    /// convert input format to minutes
    /// </summary>
    class Minutes : GetDate
    {
        private DateTime dateTime;

        public Minutes(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string GetInFormat(string format)
        {
            string outputMinutes = dateTime.Minute.ToString();
            if (format.Length == 2)
            {
                if (outputMinutes.Length == 1)
                {
                    outputMinutes = string.Concat("0", outputMinutes);
                }
            }
            return outputMinutes;
        }
    }
}
