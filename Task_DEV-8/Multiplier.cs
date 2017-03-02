namespace task_DEV_8
{
    /// <summary>
    /// Class multiplies what enters as an argument
    /// </summary>
    class Multiplier
    {
        /// <summary>
        /// Multiply two matrix
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second matrix</param>
        /// <returns>result</returns>
        public double[,] Multiply(double[,] firstMatrix, double[,] secondMatrix)
        {
            int resultColumnCount = firstMatrix.GetLength(0);
            int resultLineCount = secondMatrix.GetLength(1);
            double[,] result = new double[resultColumnCount,resultLineCount];
            for (int i = 0; i < resultColumnCount; i++)
            {
                for (int j = 0; j < resultLineCount; j++)
                {
                    for (int z = 0; z < firstMatrix.GetLength(1); z++)
                    {
                        result[i, j] += firstMatrix[i, z] * secondMatrix[z, j];
                    }
                }
            }
            return result;
        }
    }
}
