namespace task_DEV_4
{
    /// <summary>
    /// class in which searched words which have more than 5 symbols
    /// </summary>
    class MoreThanFiveChars
    {
        private int wordsCount;

        /// <summary>
        /// Searching words that have more than 5 symbols
        /// </summary>
        /// <param name="inputString">input string</param>
        public void SearchingWords(string inputString)
        {
            string[] allWords = inputString.Split(' ');
            foreach (string word in allWords)
            {
                if (word.Length > 5)
                {
                    wordsCount++;
                }
            }
        }

        /// <summary>
        /// Overrided method ToString 
        /// </summary>
        /// <returns>string which contains number of words which have more than 5 symbols</returns>
        public override string ToString()
        {
            return string.Concat("Number of words longer than five letters : ", wordsCount);
        }

    }
}
