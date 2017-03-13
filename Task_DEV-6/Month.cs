using System;

namespace task_DEV_6
{
    /// <summary>
    /// convert input format month
    /// </summary>
    public class Month : IGetDateOrTime
    {
        private DateTime dateTime;
        string[] month = new string[] { "January", "February", "March", "April", "May", "June", "July",
            "August", "September", "October", "November", "December" };

        public Month(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string GetInFormat(string format)
        {
            string outputMonth = string.Empty;
            if (format.Length == 1)
            {
                outputMonth = dateTime.Month.ToString();
            }
            if (format.Length == 2)
            {
                if (dateTime.Month < 10)
                {
                    outputMonth = string.Concat("0", dateTime.Month.ToString());
                }
                else
                {
                    outputMonth = dateTime.Month.ToString();
                }
            }
            if (format.Length == 3)
            {
                outputMonth = month[dateTime.Month - 1].Substring(0, 3);
            }
            if (format.Length == 4)
            {
                outputMonth = month[dateTime.Month - 1];
            }
            return outputMonth;
        }
    }
}
