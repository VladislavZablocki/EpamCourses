using System;

namespace task_DEV_6
{
    /// <summary>
    /// convert input format to year
    /// </summary>
    public class Year : IGetDateOrTime
    {
        private DateTime dateTime;

        public Year(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public string GetInFormat(string format)
        {
            string outputYear = dateTime.Year.ToString();
            if (format.Length == 1)
            {
                outputYear = outputYear.Substring(outputYear.Length-2,2);
                if (outputYear[0] == 0)
                {
                    outputYear = outputYear[1].ToString();
                }
            }
            if (format.Length == 2)
            {
                outputYear = outputYear.Substring(outputYear.Length - 2, 2);
            }
            if (format.Length == 3)
            {
                if (outputYear.Length < 3)
                {
                    outputYear = string.Concat("0", outputYear);
                }
            }
            if (format.Length == 4)
            {
                outputYear = outputYear.Substring(outputYear.Length - 4, 4);
            }
            if (format.Length == 5)
            {
                if (outputYear.Length < 5)
                {
                    outputYear = string.Concat("0", outputYear);
                }
                else
                {
                    outputYear = outputYear.Substring(outputYear.Length - 5, 5);
                }
            }
            return outputYear;
        }
    }
}
