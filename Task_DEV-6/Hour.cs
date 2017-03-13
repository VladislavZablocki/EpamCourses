using System;

namespace task_DEV_6
{
    /// <summary>
    /// convert input format to hour
    /// </summary>
    public class Hour : IGetDateOrTime
    {
        private DateTime dateTime;

        public Hour(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string GetInFormat(string format)
        {
            string outputHour = dateTime.Hour.ToString();
            if (format.Contains("H"))
            {
                if (format.Length == 2)
                {
                    if (int.Parse(outputHour) < 10)
                    {
                        outputHour = string.Concat("0", outputHour);
                    }
                }
            }
            else
            {
                if (int.Parse(outputHour) > 12)
                {
                    outputHour = (int.Parse(outputHour) - 12).ToString(); 
                }
                if (format.Length == 2)
                {
                    if (int.Parse(outputHour) < 10)
                    {
                        outputHour = string.Concat("0", outputHour);
                    }
                }
            }
            return outputHour;
        }
    }
}
