namespace task_DEV_4
{
    /// <summary>
    /// Class keeps set of letter, count of this sets in all strings before
    /// and frequency of this sets
    /// </summary>
    class SetOfLetter
    {
        private string set;
        private int count;
        private double frequency;

        // fields properties 
        public string Set
        {
            get
            {
                return set;
            }
            set
            {
                set = value;
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
        /// <returns>string which contain set of letter and frequency</returns>
        public override string ToString()
        {
            return string.Concat("Set of letter : ", set,
                " ; frequency : ", frequency.ToString("0.000"));
        }

    }
}
