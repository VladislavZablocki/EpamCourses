namespace task_DEV_3
{
    /// <summary>
    /// Class which check input information
    /// </summary>
    class Checker
    {
        /// <summary>
        /// Checks for the correct name
        /// </summary>
        /// <param name="name">Inputed name</param>
        /// <returns>true if correct, false if incorrect</returns>
        public bool CheckName(string name)
        {
            if (string.Empty==name)
            {
                return false;
            }
            foreach(var item in name)
            {
                if (char.IsNumber(item))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks for the correct surname
        /// </summary>
        /// <param name="surname">Inputed surname</param>
        /// <returns>true if correct, false if incorrect</returns>
        public bool CheckSurname(string surname)
        {
            if (surname == "")
            {
                return false;
            }
            foreach (var item in surname)
            {
                if (char.IsNumber(item))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Checks for the correct age
        /// </summary>
        /// <param name="age">Inputed age</param>
        /// <returns>true if correct, false if incorrect</returns>
        public bool CheckAge(int age)
        {
            return (age > 0);
        }

        /// <summary>
        /// Checks for the correct sex
        /// </summary>
        /// <param name="sex">Inputed sex</param>
        /// <returns>true if correct, false if incorrect</returns>
        public bool CheckSex(string sex)
        {
            return (string.Compare(sex, "man") == 0 || string.Compare(sex, "women") == 0);
        }
    }
}
