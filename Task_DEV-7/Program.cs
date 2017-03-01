using System;

namespace task_DEV_7
{
    class Program
    {
        /// <summary>
        /// Entry point of programm. Input date and time in correct format
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Inputer inputer = new Inputer();
            DateAndTime dateAndTime = new DateAndTime();
            Converter converter = new Converter();
            FormatChecker formatCheacker = new FormatChecker();
            string inputString = inputer.Input().Trim();
            if (formatCheacker.Check(inputString))
            {
                dateAndTime = converter.Convert(inputString);
                DateAndTimeChecker dateAndTimeChecker = new DateAndTimeChecker(dateAndTime);
                dateAndTimeChecker.Check();
            }
            Console.ReadKey();
        }
    }
}
