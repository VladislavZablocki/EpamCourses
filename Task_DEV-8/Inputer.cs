using System;

namespace task_DEV_8
{
    /// <summary>
    /// Input matrix
    /// </summary>
    class Inputer
    {
        /// <summary>
        /// Input counts of Line and Column. After that input elements of matrix
        /// </summary>
        /// <returns>matrix</returns>
        public double[,] InputElementsOfArray()
        {
            uint countLine = 0;
            uint countColumn = 0;
            InputCountOfLineAndColumn(ref countColumn, ref countLine);
            double[,] matrix = new double[countLine, countColumn];
            Console.WriteLine("Input elements of matrix : ");
            for (int i = 0; i < countLine; i++)
            {
                for (int j = 0; j < countColumn; j++)
                {
                    do
                    {
                        Console.Write("matrix[{0},{1}] = ", i, j);
                    }
                    while (!double.TryParse(Console.ReadLine(), out matrix[i, j]));
                }
            }
            return matrix;
        }

        /// <summary>
        /// Input count of line and column
        /// </summary>
        /// <param name="countColumn"></param>
        /// <param name="countLine"></param>
        private void InputCountOfLineAndColumn(ref uint countColumn,ref uint countLine )
        {
            while (countColumn <= 0 || countLine <= 0)
            {
                do
                {
                    Console.Write("Input the count of line : ");
                }
                while (!uint.TryParse(Console.ReadLine(), out countLine));
                do
                {
                    Console.Write("Input the count of column : ");
                }
                while (!uint.TryParse(Console.ReadLine(), out countColumn));
            }
        }
    }
}
