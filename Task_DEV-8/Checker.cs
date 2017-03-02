namespace task_DEV_8
{
    /// <summary>
    /// Check matrix
    /// </summary>
    class Checker
    {
        /// <summary>
        /// Check possibility to multiply
        /// </summary>
        /// <param name="firstMatrix">first matrix</param>
        /// <param name="secondMatrix">second matrix</param>
        /// <returns>coefficient;if matrix can't multiply coefficient = 0
        /// if first multiply with second coefficient = 1
        /// if second multiply with first coefficient = 2</returns>
        public int CheckPossibilityToMultiply(double[,] firstMatrix, double[,] secondMatrix)
        {
            int coefficient = 0;
            if (secondMatrix.GetLength(1) == firstMatrix.GetLength(0))
            {
                coefficient = 2;
            }
            if(firstMatrix.GetLength(1)==secondMatrix.GetLength(0))
            {
                coefficient = 1;
            }
            return coefficient;
        }
    }
}
