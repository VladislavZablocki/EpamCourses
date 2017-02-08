using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    // This class alows us to write options from command line
    class Parser
    {
        public string[] splittingOptions;
        public Parser(string[] splittingOptions)
        {
            this.splittingOptions = splittingOptions;
            WriteOnConsoleOptions();
        }
        private void WriteOnConsoleOptions()
        {
            Console.WriteLine("Your input options : ");
            foreach (var item in splittingOptions)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

   

    // This class has a method "RandomingThreeOptions", which returns to us array 
    // with three numbers. These numbers indicate which three options will be printed.
    class Rarandomizer
    {
        int[] numberOfThreeOptions = new int[3];
        Random random = new Random();
        public int[] RandomingThreeOptions(int maxNumberOfRandom)
        {
            for (int i = 0; i < 3; )
            {
                int similarity = 0;
                int randomNumber = random.Next(1, maxNumberOfRandom + 1);
                foreach (var items in numberOfThreeOptions)
                {
                    if (items == randomNumber)
                    {
                        similarity++;
                    }
                }
                if (similarity == 0)
                {
                    numberOfThreeOptions[i] = randomNumber;
                    i++;
                }
            }
            return numberOfThreeOptions;
        }
    }

    // This class use array with three numbers from class Randomizer and 
    // splitting options from class Parser. Method Print display these three options.
    class Printer
    {
        int[] numberOfThreeOptions;
        public string[] splittingOptions;

        public Printer(string[] splittingOptions, int[] numberOfThreeOptions)
        {
            this.numberOfThreeOptions = numberOfThreeOptions;
            this.splittingOptions = splittingOptions;
        }

        public void Print()
        {

            foreach (var items in numberOfThreeOptions)
            {
                Console.WriteLine(splittingOptions[items - 1]);
            }
            Console.WriteLine("Press any key to finish...");
            Console.ReadLine();
        }
    }

    // Class in which program started.
    // Also we take options from command line.
    class MainProgram
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser(args);
            if (Resolution(parser.splittingOptions.Length) == false)
            {
                return;
            }
            else
            {
                Rarandomizer randomizer = new Rarandomizer();
                Printer printer = new Printer(parser.splittingOptions, randomizer.RandomingThreeOptions(parser.splittingOptions.Length));
                printer.Print();
            }
        }

        static bool Resolution(int resolution)
        {
            if (resolution < 3)
            {
                Console.WriteLine("Your number of options less than 3.Press any key to finish...");
                Console.ReadLine();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
