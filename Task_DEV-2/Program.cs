using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    // Main class of programm. 
    class Program
    {
        // In this method we take input string from console
        // or cammand line and check this string;
        static void Main(string[] args)
        {
            string inputString=null;

            if (args.Length == 0)
            {
                inputString = Console.ReadLine();
            }
            else
            {
                foreach (var item in args)
                {
                    inputString = String.Concat(inputString, item);
                }
            }
            Checker checker = new Checker();
            if(checker.CheakInputString(ref inputString))
            {
                Calculator calculator = new Calculator(inputString);
                Console.WriteLine(calculator.Calculate());
                Console.ReadKey();
            }
        }
    }
}
