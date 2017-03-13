using System;
using System.Collections.Generic;

namespace task_DEV_6
{
    /// <summary>
    /// Class which convert input string to real date and time
    /// </summary>
    public class DateAndTimeUserFormatsConverter
    {
        //list which consists strings with formats and not formats
        private List<string> splittigStrings = new List<string>();
        private List<string> formatSymbols = new List<string>() 
        { "d", "M", "y", "h", "H", "m", "s", "F", "f" };
        private DateTime dateTime = DateTime.Now;

        /// <summary>
        /// convert input strng to real date and time
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns>string with real time and date</returns>
        public string Convert(string inputString)
        {
            IGetDateOrTime getDateOrTime = null;
            SplitingString(inputString);
            string outputDateAndTime = string.Empty;
            foreach (var item in splittigStrings)
            {
                int indexOfDateOrTime = formatSymbols.IndexOf(item[0].ToString());
                getDateOrTime = ChooseFormat(indexOfDateOrTime);
                if (getDateOrTime != null)
                {
                    outputDateAndTime = string.Concat(outputDateAndTime, getDateOrTime.GetInFormat(item));
                    getDateOrTime = null;
                }
                else
                {
                    outputDateAndTime = string.Concat(outputDateAndTime, item);
                }
            }
            return outputDateAndTime;
        }

        /// <summary>
        /// return date or time wich we need to write
        /// </summary>
        /// <param name="indexOfDateOrTime">index coincidence with format symbols</param>
        /// <returns>date or time</returns>
        private IGetDateOrTime ChooseFormat(int indexOfDateOrTime)
        {
            IGetDateOrTime getDate = null;
            if (indexOfDateOrTime == 0)
            {
                getDate = new Day(dateTime);
            }
            else if (indexOfDateOrTime == 1)
            {
                getDate = new Month(dateTime);
            }
            else if (indexOfDateOrTime == 2)
            {
                getDate = new Year(dateTime);
            }
            else if (indexOfDateOrTime == 3 || indexOfDateOrTime == 4)
            {
                getDate = new Hour(dateTime);
            }
            else if (indexOfDateOrTime == 5)
            {
                getDate = new Minutes(dateTime);
            }
            else if (indexOfDateOrTime == 6)
            {
                getDate = new Seconds(dateTime);
            }
            else if (indexOfDateOrTime == 7 || indexOfDateOrTime == 8)
            {
                getDate = new PartOfSecond(dateTime);
            }
            return getDate;
        }

        /// <summary>
        /// method which split input string on formats and not formats
        /// </summary>
        /// <param name="inputString"></param>
        private void SplitingString(string inputString)
        {
            string cell = null;
            int index = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                index = formatSymbols.IndexOf(inputString[i].ToString());
                if (index >= 0)
                {
                    if (!string.IsNullOrEmpty(cell))
                    {
                        splittigStrings.Add(cell);
                        cell = null;
                    }
                    splittigStrings.Add(FullFormat(ref i, inputString));
                }
                else
                {
                    cell = string.Concat(cell, inputString[i]);
                }
            }
            if (!string.IsNullOrEmpty(cell))
            {
                splittigStrings.Add(cell);
                cell = null;
            }
        }

        /// <summary>
        /// if we found symbol of any format we call this method
        /// and find all neighboring symbol of this format
        /// </summary>
        /// <param name="index">index of first format symbol </param>
        /// <param name="inputString"></param>
        /// <returns>string with all neighboring symbol of format</returns>
        private string FullFormat(ref int index, string inputString)
        {
            string format = null;
            int i = 0;
            for (i = index; i < inputString.Length; i++)
            {
                if (inputString[i] == inputString[index])
                {
                    format = string.Concat(format, inputString[i]);
                }
                else
                {
                    break;
                }
            }
            index = i - 1;
            return format;
        }
    }
}
