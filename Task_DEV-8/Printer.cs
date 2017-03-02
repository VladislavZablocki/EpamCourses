using System;

namespace task_DEV_8
{
    /// <summary>
    /// Class print what enters as an argument
    /// </summary>
    class Printer
    {
        /// <summary>
        /// Print matrix
        /// </summary>
        /// <param name="matrix">matrix</param>
        public void Print(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}  ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
