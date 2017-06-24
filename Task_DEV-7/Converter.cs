using System;

namespace task_DEV_7
{
    /// <summary>
    /// Convert input string to instance of the class DateAndTime
    /// </summary>
    class Converter
    {
        /// <summary>
        /// Convert string with date and time to object of class DateAndTime
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public DateAndTime Convert(string inputString)
        {
            DateAndTime dateAndTime = new DateAndTime();
            char[] separators = { ':', '/', ' ' };
            string[] elementsOfDateAndTime = inputString.Split(separators);
            int index = 0;
            dateAndTime.Hour = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime, index++);
            dateAndTime.Minute = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime, index++);
            dateAndTime.Day = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime,  index++);
            dateAndTime.Month = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime,  index++);
            dateAndTime.Year = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime,  index++);
            return dateAndTime;
        }

        /// <summary>
        /// Parse string with date or time to int value
        /// </summary>
        /// <param name="elementsOfDateAndTime"></param>
        /// <param name="index"></param>
        /// <returns>date or time in int</returns>
        private int ParseElementOfDateOrTimeToInt(string[] elementsOfDateAndTime, int index)
        {
            int element =  int.Parse(elementsOfDateAndTime[index]);
            return element;
        }
    }
}
