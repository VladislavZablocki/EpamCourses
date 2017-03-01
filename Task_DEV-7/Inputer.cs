using System;

namespace task_DEV_7
{
    /// <summary>
    /// Input date and time
    /// </summary>
    class Inputer
    {
        /// <summary>
        /// Output message with correct format.
        /// </summary>
        /// <returns>input date and time</returns>
        public string Input()
        {
            Console.WriteLine("Input date and time in next format : HH:mm dd/MM/yyyy");
            return Console.ReadLine();
        }
    }
}
