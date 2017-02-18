namespace task_DEV_4
{
    /// <summary>
    /// Class keeps pair of letter, count of this pair in all strings before
    /// and frequency of this pair
    /// </summary>
    class PairOfLetter
    {
        private string pair;
        private int count;
        private double frequency;

        // fields properties 
        public string Pair 
        {
            get
            {
                return pair;
            }
            set
            {
                pair = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
            set
            {
                count += value;
            }
        }

        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
            }
        }

        /// <summary>
        /// Overrided method ToString 
        /// </summary>
        /// <returns>string which conrain pair of letter and frequency</returns>
        public override string ToString()
        {
            return string.Concat("Pair of letter : ",pair,
                " ; frequency : ",frequency.ToString("0.000"));
        }

    }
}
