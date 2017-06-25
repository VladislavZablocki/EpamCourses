using System;

namespace task_DEV_8
{
    /// <summary>
    /// Entry point of programm. Input two matrix and multiply them,if it's possible
    /// </summary>
    class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                Inputer inputer = new Inputer();
                Matrix firstMatrix = new Matrix(inputer.InputElementsOfArray());
                Matrix secondMatrix = new Matrix(inputer.InputElementsOfArray());
                Matrix result = firstMatrix * secondMatrix;
                result.Print();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
