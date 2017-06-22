namespace task_DEV_12
{
    public class Validator
    {
        private string letterCoordinate = "abcdefgh";
        private string numberCoordinate = "12345678";

        /// <summary>
        /// Check input string with position for correctness
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool IsCorrectPosition(string position)
        {
            bool isCorrect = true;
            if (position == null || position == string.Empty)
            {
                isCorrect = false;
            }
            else
            {
                if (position.Length != 2)
                {
                    isCorrect = false;
                }
                if (!letterCoordinate.Contains(position[0].ToString()))
                {
                    isCorrect = false;
                }
                if (!numberCoordinate.Contains(position[1].ToString()))
                {
                    isCorrect = false;
                }
            }
            return isCorrect;
        }

        /// <summary>
        /// Check sting with input color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public bool IsCorrectColor(string color)
        {
            bool isCorrect = true;
            if (!(string.Equals(color, "white") || string.Equals(color, "black")))
            {
                isCorrect = false;
            }
            return isCorrect;
        }

        /// <summary>
        /// Check position for black color of cell
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool IsBlackCell(int[] position)
        {
            bool isCorrect = true;
            if ((position[0] + position[1]) % 2 != 0)
            {
                isCorrect = false;
            }
            return isCorrect;
        }
    }
}
