using System;

namespace task_DEV_12
{
    /// <summary>
    /// Input data of checker 
    /// </summary>
    public class Inputer
    {
        /// <summary>
        /// Input current position
        /// </summary>
        /// <returns></returns>
        public string InputCurrentPosition()
        {
            Console.WriteLine("Input current position of checker : ");
            string currentPosition = Console.ReadLine();
            return currentPosition;
        }

        /// <summary>
        /// Input desired position
        /// </summary>
        /// <returns></returns>
        public string InputDesiredPosition()
        {
            Console.WriteLine("Input desired position of checker : ");
            string desiredPosition = Console.ReadLine();
            return desiredPosition;
        }

        /// <summary>
        /// Input color
        /// </summary>
        /// <returns></returns>
        public string InputColor()
        {
            Console.WriteLine("Input checker color : ");
            string color = Console.ReadLine();
            return color;
        }
    }
}
