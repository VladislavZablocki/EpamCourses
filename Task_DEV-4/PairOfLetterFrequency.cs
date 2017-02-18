using System;
using System.Collections.Generic;

namespace task_DEV_4
{
    /// <summary>
    /// Class which calculate frequency for pair of letter and output their
    /// </summary>
    class PairOfLetterFrequency
    {
        private List<string> allPairs = new List<string>();
        private List<PairOfLetter> notDuplicatePairs = new List<PairOfLetter>();
        int countOfAllPairs;

        /// <summary>
        /// Calculate frequency for pair of letter
        /// </summary>
        /// <param name="inputString">last input string</param>
        public void CalculateFrequency(string inputString)
        {
            ConvertToPair(inputString);
            IdentificationOriginalPairs();
            foreach (var item in notDuplicatePairs)
            {
                item.Frequency = (double)(item.Count) / countOfAllPairs;
            }
        }

        /// <summary>
        /// Convert input string to pair of letters for example:
        /// qw.ert -- qw er rt
        /// and add this pairs to list allPairs
        /// </summary>
        /// <param name="inputString">last input string</param>
        private void ConvertToPair(string inputString)
        {
            inputString = inputString.Replace(" ", "");
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (char.IsLetter(inputString[i]) && char.IsLetter(inputString[i + 1]))
                {
                    allPairs.Add(string.Concat(inputString[i], inputString[i + 1]));
                }
            }
            countOfAllPairs += allPairs.Count;
        }

        /// <summary>
        /// we add to list notDuplicatePairs only original pairs
        /// from list allPairs
        /// </summary>
        private void IdentificationOriginalPairs()
        {
            foreach (string items in allPairs)
            {
                bool isNeedToAdd = true;
                foreach (var notduplicate in notDuplicatePairs)
                {
                    if (notduplicate.Pair.CompareTo(items) == 0)
                    {
                        isNeedToAdd = false;
                        notduplicate.Count = 1;
                        break;
                    }
                }
                if (isNeedToAdd)
                {
                    PairOfLetter pairOfLetter = new PairOfLetter();
                    pairOfLetter.Pair = items;
                    pairOfLetter.Count = 1;
                    notDuplicatePairs.Add(pairOfLetter);
                }
            }
        }

        /// <summary>
        /// Output all original pairs and frequency
        /// </summary>
        public void OutpurPairs()
        {
            Console.WriteLine("Frequency : ");
            foreach (var item in notDuplicatePairs)
            {
                Console.WriteLine(item.ToString());
            }
            allPairs.Clear();
        }
    }
}
