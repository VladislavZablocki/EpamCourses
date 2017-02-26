using System;

namespace task_DEV_6
{
    /// <summary>
    /// convert input format month
    /// </summary>
    class Month : GetDate
    {
        private DateTime dateTime;
        enum month { January, February, March, April, May, June, July,
            August, September, October, November, December };

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
                outputMonth = getMonth(dateTime.Month).ToString().Substring(0, 3);
            }
            if (format.Length == 4)
            {
                outputMonth = getMonth(dateTime.Month).ToString();
            }

            return outputMonth;
        }

        private month getMonth(int indexOfMonth)
        {
            switch(indexOfMonth)
            {
                case 1:
                    return month.January;
                case 2:
                    return month.February;
                case 3:
                    return month.March;
                case 4:
                    return month.April;
                case 5:
                    return month.May;
                case 6:
                    return month.June;
                case 7:
                    return month.July;
                case 8:
                    return month.August;
                case 9:
                    return month.September;
                case 10:
                    return month.October;
                case 11:
                    return month.November;
                case 12:
                    return month.December;
                default :
                    return month.January;
            }
        }
    }
}
