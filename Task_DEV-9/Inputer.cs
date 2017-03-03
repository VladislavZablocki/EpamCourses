using System;

namespace task_DEV_9
{
    /// <summary>
    /// Input parameters
    /// </summary>
    class Inputer
    {
        /// <summary>
        /// Input section
        /// </summary>
        /// <returns>string section</returns>
        public string InputSection()
        {
            Console.WriteLine("Input section :");
            return Console.ReadLine();
        }

        /// <summary>
        /// Input key
        /// </summary>
        /// <returns>string key</returns>
        public string InputKey()
        {
            Console.WriteLine("Input key : ");
            return Console.ReadLine();
        }
    }
}
