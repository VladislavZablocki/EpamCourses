﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
<<<<<<< HEAD:Task-2/Task-2/MainProgram.cs

    // This class alows us to write options from command line
=======
    // This class alows us to take options from command line
    // and write these options
>>>>>>> b2f1862010155bd96dd429f758790e05e5923e01:Task-2/Task-2/Program.cs
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

    // This class we use to check number of options.
    // If less than three programm will be exits.
    class Checker
    {
        public string[] splittingOptions;

        public Checker(string[] splittingOptions)
        {
            this.splittingOptions = splittingOptions;
        }

        public bool Check()
        {
            if (splittingOptions.Length < 3)
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

    // This class has a method "RandomingThreeOptions", which returns to us array 
    // with three numbers. These numbers indicate which three options will be printed.
    class Rarandomizer
    {
        int[] numberOfThreeOptions = new int[3];
        Random random = new Random();
        public Rarandomizer()
        { }

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
        int numberOfSplittingOptions;

        public Printer(string[] splittingOptions, int[] numberOfThreeOptions)
        {
            this.numberOfThreeOptions = numberOfThreeOptions;
            this.splittingOptions = splittingOptions;
            this.numberOfSplittingOptions = splittingOptions.Length;
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
<<<<<<< HEAD:Task-2/Task-2/MainProgram.cs

    // Class in which program started.
    // Also we take options from command line.
    class MainProgram
=======
   
    // Class in which program started.
    // Also we take options from command line.
    class Main
>>>>>>> b2f1862010155bd96dd429f758790e05e5923e01:Task-2/Task-2/Program.cs
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
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}