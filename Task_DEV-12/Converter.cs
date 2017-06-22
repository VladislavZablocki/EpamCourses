namespace task_DEV_12
{
    /// <summary>
    /// Convert input string to needed format
    /// </summary>
    public class Converter
    {
        private string letterCoordinate = "abcdefgh";

        /// <summary>
        /// Convert input string a1 to array {1;1}
        /// </summary>
        /// <param name="inputPosition">input string</param>
        /// <returns>array with coordinate</returns>
        public int[] ConvertToNumberFormat(string inputPosition)
        {
            int[] outputPosition = new int[2];
            outputPosition[0] = letterCoordinate.IndexOf(inputPosition[0]) + 1;
            outputPosition[1] = int.Parse(inputPosition[1].ToString());
            return outputPosition;
        }

        /// <summary>
        /// Trim string with color and convert to lower format
        /// </summary>
        /// <param name="color">string with color</param>
        /// <returns>string with color</returns>
        public string ColorTrimAndToLower(string color)
        {
            color = color.Trim();
            color = color.ToLower();
            return color;
        }
    }
}
