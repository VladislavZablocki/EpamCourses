using System;
using System.Collections.Generic;

namespace task_DEV_4
{
    /// <summary>
    /// Class which calculate frequency for sets of letter and output their
    /// </summary>
    class SetOfLetterFrequency
    {
        private List<string> allSets = new List<string>();
        private List<SetOfLetter> notDuplicateSets = new List<SetOfLetter>();
        private int countOfAllSets;
        private const int lengthOfSet = 2;

        /// <summary>
        /// Calculate frequency for sets of letter
        /// </summary>
        /// <param name="inputString">last input string</param>
        public void CalculateFrequency(string inputString)
        {
            ConvertToSet(inputString);
            IdentificationOriginalSets();
            foreach (var item in notDuplicateSets)
            {
                item.Frequency = (double)(item.Count) / countOfAllSets;
            }
        }

        /// <summary>
        /// Convert input string to set of letters for example:
        /// qw.er t --> qw er rt
        /// and add this sets to list allSets
        /// </summary>
        /// <param name="inputString">last input string</param>
        private void ConvertToSet(string inputString)
        {
            inputString = inputString.Replace(" ", "");
            for (int i = 0; i < inputString.Length - lengthOfSet + 1; i++)
            {
                string set = inputString.Substring(i, lengthOfSet);
                if (CheckSet(set))
                {
                    allSets.Add(set);
                }
            }
            countOfAllSets += allSets.Count;
        }

        /// <summary>
        /// Check set of letters
        /// </summary>
        /// <param name="set">set from input string</param>
        /// <returns>if set contain only letter (a-z,A-Z) return true
        /// else return false </returns>
        private bool CheckSet(string set)
        {
            int count = 0;
            foreach(char item in set)
            {
                // check is symbol in set is letter
                if ((item > '\u0040' && item < '\u005B') ||
                   (item > '\u0060' && item < '\u007B'))  
                {
                    count++;
                    if (count == lengthOfSet)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// we add to list notDuplicateSets only original Sets
        /// from list allSets
        /// </summary>
        private void IdentificationOriginalSets()
        {
            foreach (string items in allSets)
            {
                bool isNeedToAdd = true;
                foreach (var notduplicate in notDuplicateSets)
                {
                    if (notduplicate.Set.CompareTo(items) == 0) // if this set not original
                    {
                        isNeedToAdd = false;
                        notduplicate.Count = 1;
                        break;
                    }
                }
                if (isNeedToAdd) // if this set is new (original)
                {
                    SetOfLetter setOfLetter = new SetOfLetter();
                    setOfLetter.Set = items;
                    setOfLetter.Count = 1;
                    notDuplicateSets.Add(setOfLetter);
                }
            }
        }

        /// <summary>
        /// Output all original Sets and frequency
        /// </summary>
        public void OutputSets()
        {
            Console.WriteLine("Frequency : ");
            foreach (var item in notDuplicateSets)
            {
                Console.WriteLine(item.ToString());
            }
            allSets.Clear();
        }
    }
}
