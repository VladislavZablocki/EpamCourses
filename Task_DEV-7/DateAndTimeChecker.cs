using System;

namespace task_DEV_7
{
    /// <summary>
    /// Check date and time for valid values
    /// </summary>
    class DateAndTimeChecker
    {
        private DateAndTime dateAndTime;
        private int[] dayInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private const int MaxValueOfYear = 9999;
        private const int MaxValueOfMonth = 12;
        private const int MaxValueOfHour = 24;
        private const int MaxValueOfMinutes = 60;

        public DateAndTimeChecker(DateAndTime dateAndTime)
        {
            this.dateAndTime = dateAndTime;
        }

        /// <summary>
        /// Check all elements of date and time
        /// </summary>
        public void Check()
        {
            if (!CheckYear())
            {
                Console.WriteLine("Year is incorrect!");
            }
            if (!CheckMonth())
            {
                Console.WriteLine("Month is incorrect!");
            }
            if (!CheckDay())
            {
                Console.WriteLine("Day is incorrect!");
            }
            if (!CheckHour())
            {
                Console.WriteLine("Hour is incorrect!");
            }
            if (!CheckMinutes())
            {
                Console.WriteLine("Minutes are incorrect!");
            }
        }

        /// <summary>
        /// Check year for valid values
        /// </summary>
        /// <returns>if valid - true; else - false</returns>
        private bool CheckYear()
        {
            return (dateAndTime.Year>=0 && dateAndTime.Year<=MaxValueOfYear);
        }

        /// <summary>
        /// Check month for valid values
        /// </summary>
        /// <returns>if valid - true; else - false</returns>
        private bool CheckMonth()
        {
            return (dateAndTime.Month > 0 && dateAndTime.Month <= MaxValueOfMonth);
        }

        /// <summary>
        /// Check day for valid values
        /// </summary>
        /// <returns>if valid - true; else - false</returns>
        private bool CheckDay()
        {
            return (dateAndTime.Day > 0 && dateAndTime.Day <= MaxNumberOfDayInMonth());
        }

        /// <summary>
        /// Check hour for valid values
        /// </summary>
        /// <returns>if valid - true; else - false</returns>
        private bool CheckHour()
        {
            return (dateAndTime.Hour >= 0 && dateAndTime.Hour < MaxValueOfHour);
        }

        /// <summary>
        /// Check minutes for valid values
        /// </summary>
        /// <returns>if valid - true; else - false</returns>
        private bool CheckMinutes()
        {
            return (dateAndTime.Minute >= 0 && dateAndTime.Minute < MaxValueOfMinutes);
        }

        /// <summary>
        /// check is year is leap(366 day)
        /// </summary>
        /// <returns>if leap year - true; else - false</returns>
        private bool IsLeapYear()
        {
            return ((dateAndTime.Year % 4 == 0 && dateAndTime.Year % 100 != 0) || (dateAndTime.Year % 400 == 0));
        }

        /// <summary>
        /// Determines how many days in a given month
        /// </summary>
        /// <returns>number of day</returns>
        private int MaxNumberOfDayInMonth()
        {
            int day = dayInMonth[dateAndTime.Month];
            if (dateAndTime.Month == 2 && IsLeapYear())
            {
                day++;
            }
            return day;
        }

    }
}
