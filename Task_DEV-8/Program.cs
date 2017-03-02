using System;

namespace task_DEV_8
{
    /// <summary>
    /// Entry point of programm. Input two matrix and multiply them,if it's possible
    /// </summary>
    class Program
    {
        const int CoefficientFirstSecond = 1;
        const int CoefficientSecondFirst = 2;
        static void Main(string[] args)
        {
            Inputer inputer = new Inputer();
            Checker checker = new Checker();
            Multiplier multiplier = new Multiplier();
            Printer printer = new Printer();
            double[,] firstMatrix = inputer.Input();
            double[,] secondMatrix = inputer.Input();
            double[,] result = null;
            int checkCoefficient = checker.CheckPossibilityToMultiply(firstMatrix, secondMatrix);
            if (checkCoefficient == 0)
            {
                Console.WriteLine("Matrix can't multiply!");
            }
            else
            {
                if (checkCoefficient == CoefficientFirstSecond)
                {
                    Console.WriteLine("First matrix multiplied with the second : ");
                    result = multiplier.Multiply(firstMatrix, secondMatrix);
                }
                if (checkCoefficient == CoefficientSecondFirst)
                {
                    Console.WriteLine("Second matrix multiplied with the first : ");
                    result = multiplier.Multiply(secondMatrix, firstMatrix);
                }
                printer.Print(result);
            }
            Console.ReadKey();
        }
    }
}
