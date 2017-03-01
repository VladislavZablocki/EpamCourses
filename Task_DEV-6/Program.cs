using System;

namespace task_DEV_6
{
    class Program
    {
        /// <summary>
        /// Entry point of programm. Input format of date and time 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DateAndTimeWithUserFormats dateAndTimeFormater = new DateAndTimeWithUserFormats();
            Console.WriteLine(dateAndTimeFormater.Convert(Console.ReadLine()));
        }
    }
}
