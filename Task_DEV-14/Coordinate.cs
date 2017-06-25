using System;

namespace task_DEV_12
{
    /// <summary>
    /// Class with coordinate
    /// </summary>
    public class Coordinate
    {
        public enum ColorOfField { white, black };
        private string letterCoordinate = "abcdefgh";
        private string numberCoordinate = "12345678";

        public int[] Position { get; set; }

        public Coordinate()
        {
            Position = new int[2];
        }

        /// <summary>
        /// return color of field in this position
        /// </summary>
        /// <returns>enum with color</returns>
        public ColorOfField GetPositionColor()
        {
            if ((Position[0] + Position[1]) % 2 != 0)
            {
                return ColorOfField.white;
            }
            else
            {
                return ColorOfField.black;
            }
        }

        public void Input()
        {
            Console.WriteLine("Input coordinate");
            string coordinate = Console.ReadLine();
            Validate(coordinate);
            Convert(coordinate);
        }

        private void Convert(string inputPosition)
        {
            int[] outputPosition = new int[2];
            Position[0] = letterCoordinate.IndexOf(inputPosition[0]) + 1;
            Position[1] = int.Parse(inputPosition[1].ToString()); 
        }

        private void Validate(string inputString)
        {
            if (Position.Length != 2 || !letterCoordinate.Contains(inputString[0].ToString()) 
                || !numberCoordinate.Contains(inputString[1].ToString()))
            {
                throw new FormatException();
            }
        }
        
    }
}
