using System;

namespace task_DEV_7
{
    /// <summary>
    /// Convert input string to instance of the class DateAndTime
    /// </summary>
    class Converter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public DateAndTime Convert(string inputString)
        {
            DateAndTime dateAndTime = new DateAndTime();
            char[] separators = { ':', '/', ' ' };
            string[] elementsOfDateAndTime = inputString.Split(separators);
            int index = 0;
            dateAndTime.Hour = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime, ref index);
            dateAndTime.Minute = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime, ref index);
            dateAndTime.Day = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime, ref index);
            dateAndTime.Month = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime, ref index);
            dateAndTime.Year = ParseElementOfDateOrTimeToInt(elementsOfDateAndTime, ref index);
            return dateAndTime;
        }

        /// <summary>
        /// Parse string with date or time to int
        /// </summary>
        /// <param name="elementsOfDateAndTime"></param>
        /// <param name="index"></param>
        /// <returns>date or time in int</returns>
        private int ParseElementOfDateOrTimeToInt(string[] elementsOfDateAndTime, ref int index)
        {
            int element =  int.Parse(elementsOfDateAndTime[index]);
            index++;
            return element;
        }
    }
}
