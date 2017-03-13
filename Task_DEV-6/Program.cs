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
            DateAndTimeUserFormatsConverter dateAndTimeConverter = new DateAndTimeUserFormatsConverter();
            Console.WriteLine(dateAndTimeConverter.Convert(Console.ReadLine()));
        }
    }
}
