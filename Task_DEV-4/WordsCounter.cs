namespace task_DEV_4
{
    /// <summary>
    ///  Сount and store words with length = five or more letter
    /// </summary>
    class WordsCounter
    {
        private int wordsCount;
        private int length = 5;
        
        /// <summary>
        /// Searching words with length = five or more letter (a-z,A-Z) 
        /// and increased wordsCount
        /// </summary>
        /// <param name="inputString">input string</param>
        public void SearchingWords(string inputString)
        {
            string[] allWords = inputString.Split(' ');
            foreach (string word in allWords)
            {
                if (CheckWord(word))
                {
                    wordsCount++;
                }
            }
        }

        /// <summary>
        /// check word 
        /// </summary>
        /// <param name="word">word from input string which we check</param>
        /// <returns>if word have more than 5 letter(a-z,A-Z) return true,
        /// else return false </returns>
        private bool CheckWord(string word)
        {
            int count = 0;
            foreach (char item in word)
            {
                // check is symbol in word is letter
                if ((item > '\u0040' && item < '\u005B') || 
                    (item > '\u0060' && item < '\u007B'))
                {
                    count++;
                    if (count > length)
                    {
                        return true;  
                    } 
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }

        /// <summary>
        /// Overrided method ToString 
        /// </summary>
        /// <returns>string which contains number of words
        /// with length = five or more letter (a-z,A-Z) </returns>
        public override string ToString()
        {
            return string.Concat("Number of words longer than ",length, " letters : ", wordsCount);
        }

    }
}
