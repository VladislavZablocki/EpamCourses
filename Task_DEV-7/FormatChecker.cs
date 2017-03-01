using System;

namespace task_DEV_7
{
    /// <summary>
    /// Check input string in accordance with the requirement of format date and time
    /// </summary>
    class FormatChecker
    {
        /// <summary>
        /// Check separator of date and time
        /// </summary>
        /// <param name="inputString">input string with date and time</param>
        /// <returns>if format correct - true; else - false</returns>
        public bool Check(string inputString)
        {
            string separatorsInFormat = ": //";
            string separatorInInputString = string.Empty;
            foreach (char element in inputString)
            {
                if (!char.IsDigit(element))
                {
                    separatorInInputString = string.Concat(separatorInInputString, element);
                }
            }
            if (string.Compare(separatorInInputString, separatorsInFormat) == 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Check format of date and time!");
                return false;
            }
        }
    }
}
