using System;
using System.Collections.Generic;
using System.IO;

namespace task_DEV_9
{
    class Program
    {
        /// <summary>
        /// Entry point of programm.Input section and key and find all values
        /// </summary>
        /// <param name="args">Path to the file</param>
        static void Main(string[] args)
        {
            Inputer inputer = new Inputer();
            Finder finder = new Finder();
            string section = inputer.InputSection();
            string key = inputer.InputKey();
            try
            {
                List<string> result = finder.FindValuesInFile(section, key, args[0]);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error! Add path to the file");
            }
        }

    }
}
