using System;

namespace task_DEV_4
{
    class Program
    {
        /// <summary>
        /// Method in which we input string and calculate frequency and count of words
        /// that have more than 5 symols
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int count = 0;
            string inputString;
            FiveLetter moreThanFiveChars = new FiveLetter();
            PairOfLetterFrequency pairOfLetterFrequency = new PairOfLetterFrequency();
            while (count < 3)
            {
                Console.WriteLine("Enter you string");
                inputString = Console.ReadLine();
                moreThanFiveChars.SearchingWords(inputString);
                Console.WriteLine(moreThanFiveChars.ToString());
                pairOfLetterFrequency.CalculateFrequency(inputString);
                pairOfLetterFrequency.OutpurPairs();
                count++;
            }
        }
    }
}
